package org.hornetsa.services;

import org.hornetsa.model.Automobile;
import org.hornetsa.model.Bodywork;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.*;
import java.util.stream.Collectors;

@Service
public class AutomobileService {

    // Singleton instance for the AutomobileService
    private static AutomobileService automobileService;

    // List to store automobile objects
    private static ArrayList<Automobile> automobiles = new ArrayList<>();

    // Access to the BodyworkService for bodywork operations
    private static BodyworkService bodyworkService = BodyworkService.getBodyworkService();

    // Private constructor to enforce singleton pattern
    private AutomobileService() {}

    // Method to get the singleton instance of AutomobileService
    public static AutomobileService getAutomobileService() {
        if (automobileService == null) {
            automobileService = new AutomobileService();
        }
        return automobileService;
    }

    // Returns a filtered list of automobiles based on the given ID and SNID
    public List<Map<String, Object>> getAutomobiles(int id, String snid) {
        int defaultId = -1;  // Default ID for filtering

        // Filter the automobiles by ID and SNID
        return automobiles.stream()
                .filter(auto -> (id == defaultId || auto.getId() == id)
                        && (snid == null || auto.getSnid().equalsIgnoreCase(snid)))
                .map(auto -> {
                    // Replace bodywork IDs with complete Bodywork objects
                    List<Bodywork> fullBodyworks = auto.getBodyworks().stream()
                            .map(bodyworkService::findBodyworkById) // Find Bodywork by ID
                            .filter(Objects::nonNull) // Filter out non-existent Bodyworks
                            .collect(Collectors.toList());

                    // Use LinkedHashMap to maintain the order of insertion
                    Map<String, Object> response = new LinkedHashMap<>();

                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodyworks", fullBodyworks); // Add complete Bodywork objects
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                })
                .collect(Collectors.toList());
    }

    // Adds a new automobile to the list
    public void postAutomobile(Automobile automobile) {
        // Validate that exactly one Bodywork is assigned to the automobile
        if (automobile.getBodyworks().size() != 1) {
            throw new ResponseStatusException(
                    HttpStatus.BAD_REQUEST, "Each automobile must have exactly one assigned Bodywork");
        }

        // Validate that the assigned Bodywork exists
        int bodyworkId = automobile.getBodyworks().get(0);
        if (bodyworkService.findBodyworkById(bodyworkId) == null) {
            throw new ResponseStatusException(
                    HttpStatus.NOT_FOUND, "Bodywork with ID: " + bodyworkId + " not found");
        }

        // Add the automobile to the list if validations pass
        automobiles.add(automobile);
        System.out.println("Automobile added: " + automobile);
    }

    // Deletes an automobile based on its ID
    public void deleteAutomobile(int id) {
        automobiles.removeIf(a -> a.getId() == id);
    }

    // Updates an existing automobile based on its ID
    public void update(int id, Automobile automobile) {
        // Find the automobile to update
        Automobile automobileToUpdate = automobiles.stream()
                .filter(a -> a.getId() == id)
                .findFirst()
                .orElse(null);

        // Throw an exception if the automobile is not found
        if (automobileToUpdate == null) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND,
                    "Automobile with the provided ID not found");
        }

        // Validate if the assigned Bodyworks exist
        for (Integer bodyworkId : automobile.getBodyworks()) {
            if (bodyworkService.findBodyworkById(bodyworkId) == null) {
                throw new ResponseStatusException(
                        HttpStatus.NOT_FOUND, "Bodywork with ID: " + bodyworkId + " not found");
            }
        }

        // Update the fields of the automobile
        automobileToUpdate.setBrand(automobile.getBrand());
        automobileToUpdate.setPrice(automobile.getPrice());
        automobileToUpdate.setSnid(automobile.getSnid());
        automobileToUpdate.setAbsBrake(automobile.isAbsBrake());
        automobileToUpdate.setBodyworks(automobile.getBodyworks());
        automobileToUpdate.setArrivalDate(automobile.getArrivalDate());
    }
}
