package org.hornetsa.services;

import org.hornetsa.model.Bodywork;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service  // Marks this class as a Spring service component
public class BodyworkService {

    // Singleton instance of BodyworkService
    private static BodyworkService bodyworkService;

    // List to store bodywork objects
    private static ArrayList<Bodywork> bodyworks;

    // Private constructor to enforce singleton pattern
    private BodyworkService() {
        bodyworks = new ArrayList<>();  // Initialize the bodyworks list
    }

    // Method to get the singleton instance of BodyworkService
    public static BodyworkService getBodyworkService() {
        if (bodyworkService == null) {
            bodyworkService = new BodyworkService();
        }
        return bodyworkService;
    }

    // Returns the list of all bodyworks
    public ArrayList<Bodywork> getBodyworks() {
        return bodyworks;
    }

    // Returns a filtered list of bodyworks based on the given ID and name
    public List<Bodywork> getBodyworks(int id, String name) {
        int defaultId = -1;  // Default ID for filtering

        // Filter the bodyworks by ID and name
        return bodyworks.stream()
                .filter(b -> (id == defaultId || b.getId() == id)
                        && (name == null || b.getName().equalsIgnoreCase(name)))
                .collect(Collectors.toList());  // Collect the results into a list
    }

    // Adds a new bodywork to the list
    public void postBodywork(Bodywork bodywork) {
        if (bodyworks == null) {
            bodyworks = new ArrayList<>();  // Initialize the list if it's null
        }

        // Check if a bodywork with the same ID or name already exists
        if (bodyworks.stream().anyMatch(b -> b.getId() == bodywork.getId()
                || b.getName().equalsIgnoreCase(bodywork.getName()))) {
            throw new ResponseStatusException(
                    HttpStatus.CONFLICT, "A bodywork with the same ID or name already exists");
        }

        // Add the bodywork to the list if it passes validation
        bodyworks.add(bodywork);
        System.out.println(bodywork);  // Print the added bodywork to the console
    }

    // Deletes a bodywork based on its ID
    public void deleteBodywork(int id) {
        bodyworks.removeIf(b -> b.getId() == id);  // Remove bodywork by ID
    }

    // Updates an existing bodywork based on its ID
    public void update(int id, Bodywork bodywork) {
        // Find the bodywork to update
        Bodywork bodyworkToUpdate = bodyworks.stream()
                .filter(b -> b.getId() == id)
                .findFirst()
                .orElse(null);

        // Throw an exception if the bodywork is not found
        if (bodyworkToUpdate == null) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND,
                    "Bodywork with the provided ID not found");
        }

        // Update the name of the bodywork
        bodyworkToUpdate.setName(bodywork.getName());
        bodyworkToUpdate.setHasSunroof(bodywork.isHasSunroof());
    }

    // Finds and returns a bodywork by its ID
    public Bodywork findBodyworkById(int id) {
        return bodyworks.stream()
                .filter(b -> b.getId() == id)
                .findFirst()
                .orElse(null);  // Return null if no match is found
    }
}
