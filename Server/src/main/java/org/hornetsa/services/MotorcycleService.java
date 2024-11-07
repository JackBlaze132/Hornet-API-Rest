package org.hornetsa.services;

import org.hornetsa.model.Motorcycle;
import org.hornetsa.repository.MotorcycleRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;

@Service
public class MotorcycleService {

    @Autowired
    private MotorcycleRepository motorcycleRepository;

    public List<Motorcycle> getMotorcycles() {
        return motorcycleRepository.findAll();
    }

    public Motorcycle getMotorcycleById(int id) {
        return motorcycleRepository.findById(id)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Motorcycle not found"));
    }

    public Motorcycle addMotorcycle(Motorcycle motorcycle) {
        return motorcycleRepository.save(motorcycle);
    }

    public void deleteMotorcycle(int id) {
        if (!motorcycleRepository.existsById(id)) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Motorcycle not found");
        }
        motorcycleRepository.deleteById(id);
    }

    public Motorcycle updateMotorcycle(int id, Motorcycle updatedMotorcycle) {
        Motorcycle existingMotorcycle = motorcycleRepository.findById(id)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Motorcycle not found"));
        existingMotorcycle.setBrand(updatedMotorcycle.getBrand());
        existingMotorcycle.setPrice(updatedMotorcycle.getPrice());
        existingMotorcycle.setSnid(updatedMotorcycle.getSnid());
        existingMotorcycle.setAbsBrake(updatedMotorcycle.isAbsBrake());
        existingMotorcycle.setForkType(updatedMotorcycle.getForkType());
        existingMotorcycle.setHelmetIncluded(updatedMotorcycle.isHelmetIncluded());
        existingMotorcycle.setArrivalDate(updatedMotorcycle.getArrivalDate());
        return motorcycleRepository.save(existingMotorcycle);
    }
}
