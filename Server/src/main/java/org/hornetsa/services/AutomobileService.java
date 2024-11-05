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
                    Bodywork fullBodywork = bodyworkService.findBodyworkById(auto.getBodywork().getId());

                    Map<String, Object> response = new LinkedHashMap<>();
                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodywork", fullBodywork); // Cambiado para usar un solo Bodywork
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                });
    }

    public List<Map<String, Object>> getAutomobiles() {
        return automobileRepository.findAll().stream()
                .map(auto -> {
                    Bodywork fullBodywork = bodyworkService.findBodyworkById(auto.getBodywork().getId());

                    Map<String, Object> response = new LinkedHashMap<>();
                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodywork", fullBodywork); // Cambiado para usar un solo Bodywork
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                })
                .collect(Collectors.toList());
    }

    public void postAutomobile(Automobile automobile) {
        if (automobile.getBodywork() == null) {
            throw new ResponseStatusException(
                    HttpStatus.BAD_REQUEST, "Each automobile must have an assigned Bodywork");
        }

        int bodyworkId = automobile.getBodywork().getId();
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

        int bodyworkId = automobile.getBodywork().getId();
        if (bodyworkService.findBodyworkById(bodyworkId) == null) {
            throw new ResponseStatusException(
                    HttpStatus.NOT_FOUND, "Bodywork with ID: " + bodyworkId + " not found");
        }

        automobileToUpdate.setBrand(automobile.getBrand());
        automobileToUpdate.setPrice(automobile.getPrice());
        automobileToUpdate.setSnid(automobile.getSnid());
        automobileToUpdate.setAbsBrake(automobile.isAbsBrake());
        automobileToUpdate.setBodywork(automobile.getBodywork()); // Cambiado para un solo Bodywork
        automobileToUpdate.setArrivalDate(automobile.getArrivalDate());

        automobileRepository.save(automobileToUpdate);
    }
}
