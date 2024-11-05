package org.hornetsa.services;

import org.hornetsa.model.Automobile;
import org.hornetsa.model.Bodywork;
import org.hornetsa.repository.AutomobileRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.*;
import java.util.stream.Collectors;

@Service
public class AutomobileService {

    @Autowired
    private AutomobileRepository automobileRepository;

    @Autowired
    private BodyworkService bodyworkService;

    public Optional<Map<String, Object>> getAutomobile(int id, String snid) {
        return automobileRepository.findById(id)
                .map(auto -> {
                    List<Bodywork> fullBodyworks = auto.getBodyworks().stream()
                            .map(bodyworkService::findBodyworkById)
                            .filter(Objects::nonNull)
                            .collect(Collectors.toList());

                    Map<String, Object> response = new LinkedHashMap<>();
                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodyworks", fullBodyworks);
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                });
    }

    public List<Map<String, Object>> getAutomobiles() {
        return automobileRepository.findAll().stream()
                .map(auto -> {
                    List<Bodywork> fullBodyworks = auto.getBodyworks().stream()
                            .map(bodyworkService::findBodyworkById)
                            .filter(Objects::nonNull)
                            .collect(Collectors.toList());

                    Map<String, Object> response = new LinkedHashMap<>();
                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodyworks", fullBodyworks);
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                })
                .collect(Collectors.toList());
    }

    public void postAutomobile(Automobile automobile) {
        if (automobile.getBodyworks().size() != 1) {
            throw new ResponseStatusException(
                    HttpStatus.BAD_REQUEST, "Each automobile must have exactly one assigned Bodywork");
        }

        int bodyworkId = automobile.getBodyworks().get(0);
        if (bodyworkService.findBodyworkById(bodyworkId) == null) {
            throw new ResponseStatusException(
                    HttpStatus.NOT_FOUND, "Bodywork with ID: " + bodyworkId + " not found");
        }

        automobileRepository.save(automobile);
    }

    public void deleteAutomobile(int id) {
        if (!automobileRepository.existsById(id)) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Automobile not found");
        }
        automobileRepository.deleteById(id);
    }

    public void update(int id, Automobile automobile) {
        Automobile automobileToUpdate = automobileRepository.findById(id)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND,
                        "Automobile with the provided ID not found"));

        for (Integer bodyworkId : automobile.getBodyworks()) {
            if (bodyworkService.findBodyworkById(bodyworkId) == null) {
                throw new ResponseStatusException(
                        HttpStatus.NOT_FOUND, "Bodywork with ID: " + bodyworkId + " not found");
            }
        }

        automobileToUpdate.setBrand(automobile.getBrand());
        automobileToUpdate.setPrice(automobile.getPrice());
        automobileToUpdate.setSnid(automobile.getSnid());
        automobileToUpdate.setAbsBrake(automobile.isAbsBrake());
        automobileToUpdate.setBodyworks(automobile.getBodyworks());
        automobileToUpdate.setArrivalDate(automobile.getArrivalDate());

        automobileRepository.save(automobileToUpdate);
    }
}
