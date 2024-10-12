package org.hornetsa.services;

import org.hornetsa.model.Automobile;
import org.hornetsa.model.Bodywork;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class AutomobileService {

    private static AutomobileService automobileService;
    private static ArrayList<Automobile> automobiles;

    private AutomobileService() {
        automobiles = new ArrayList<>();
    }

    public static AutomobileService getAutomobileService() {
        if (automobileService == null) {
            automobileService = new AutomobileService();
        }
        return automobileService;
    }

    public ArrayList<Automobile> getAutomobiles() {
        return automobiles;
    }

    public List<Automobile> getAutomobiles(int id, String snid) {
        int defaultId = -1;
        return automobiles.stream()
                .filter(a -> (id == defaultId || a.getId() == id)
                        && (snid == null || a.getSnid().equalsIgnoreCase(snid)))
                .collect(Collectors.toList());
    }

    public void postAutomobile(Automobile automobile) {
        if (automobiles == null) {
            automobiles = new ArrayList<>();
        }

        // Verificar si ya existe un automóvil con el mismo ID o SNID
        if (automobiles.stream().anyMatch(a -> a.getId() == automobile.getId() || a.getSnid().equalsIgnoreCase(automobile.getSnid()))) {
            throw new ResponseStatusException(HttpStatus.CONFLICT, "Ya existe un automóvil con el mismo ID o SNID");
        }

        automobiles.add(automobile);
        System.out.println(automobile);
    }

    public void deleteAutomobile(int id) {
        automobiles.removeIf(a -> a.getId() == id);
    }

    public void update(int id, Automobile automobile) {
        Automobile automobileToUpdate = automobiles.stream().filter(a -> a.getId() == id).findFirst().orElse(null);
        if (automobileToUpdate == null) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "No se encontró el automóvil con el ID proporcionado");
        }
        automobileToUpdate.setBrand(automobile.getBrand());
        automobileToUpdate.setPrice(automobile.getPrice());
        automobileToUpdate.setSnid(automobile.getSnid());
        automobileToUpdate.setAbsBrake(automobile.isAbsBrake());
        automobileToUpdate.setBodyworks(automobile.getBodyworks());
        automobileToUpdate.setArrivalDate(automobile.getArrivalDate());
    }
}
