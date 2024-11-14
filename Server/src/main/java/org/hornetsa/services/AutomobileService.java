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

                    Map<String, Object> response = new LinkedHashMap<>();
                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodywork", auto.getBodywork()); // Cambiado para usar un solo Bodywork
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                });
    }

    public List<Map<String, Object>> getAutomobiles() {
        return automobileRepository.findAll().stream()
                .map(auto -> {

                    Map<String, Object> response = new LinkedHashMap<>();
                    response.put("id", auto.getId());
                    response.put("brand", auto.getBrand());
                    response.put("price", auto.getPrice());
                    response.put("snid", auto.getSnid());
                    response.put("absBrake", auto.isAbsBrake());
                    response.put("bodywork", auto.getBodywork()); // Cambiado para usar un solo Bodywork
                    response.put("arrivalDate", auto.getArrivalDate());

                    return response;
                })
                .collect(Collectors.toList());
    }

    public Automobile postAutomobile(Automobile automobile) {
        return automobileRepository.save(automobile);
    }

    public void deleteAutomobile(int id) {
        if (!automobileRepository.existsById(id)) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Automobile not found");
        }
        automobileRepository.deleteById(id);
    }

    public Automobile update(int id, Automobile automobile) {
        Automobile automobileToUpdate = automobileRepository.findById(id)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND,
                        "Automobile with the provided ID not found"));

        automobileToUpdate.setBrand(automobile.getBrand());
        automobileToUpdate.setPrice(automobile.getPrice());
        automobileToUpdate.setSnid(automobile.getSnid());
        automobileToUpdate.setAbsBrake(automobile.isAbsBrake());
        automobileToUpdate.setBodywork(automobile.getBodywork()); // Cambiado para un solo Bodywork
        automobileToUpdate.setArrivalDate(automobile.getArrivalDate());

        return automobileRepository.save(automobileToUpdate);
    }
}
