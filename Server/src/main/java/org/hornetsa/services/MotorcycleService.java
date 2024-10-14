package org.hornetsa.services;

import org.hornetsa.model.Motorcycle;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class MotorcycleService {

    private static MotorcycleService motorcycleService;
    private static ArrayList<Motorcycle>  motorcycles;

    private MotorcycleService(){
        motorcycles = new ArrayList<>();
    }

    public static MotorcycleService getMotorcycleService(){
        if(motorcycleService == null){
            motorcycleService = new MotorcycleService();
        }
        return motorcycleService;
    }

    public ArrayList<Motorcycle>  getMotorcycles() {
        return motorcycles;
    }

    public List<Motorcycle> getMotorcycle(int id, String snid) {
        int defaultId = -1;
        return this.motorcycles.stream()
                .filter(m -> (id == defaultId || m.getId() == id)
                        && (snid == null || m.getSnid().equals(snid)))
                .collect(Collectors.toList());
    }

    public void postMotorcycle(Motorcycle motorcycle) {
        if (motorcycles == null) {
            motorcycles = new ArrayList<>();
        }

        // Verificar si ya existe un motocicleta con el mismo ID o SNID
        if (motorcycles.stream().anyMatch(m -> m.getId() ==(motorcycle.getId()) || m.getSnid().equals(motorcycle.getSnid()))) {
            throw new ResponseStatusException(HttpStatus.CONFLICT, "Ya existe un motocicleta con el mismo ID o SNID");
        }

        motorcycles.add(motorcycle);
        System.out.println(motorcycle);
    }

    public void deleteMotorcycle (int id){
        motorcycles.removeIf(m -> m.getId() == id);
    }
    
    public void update (int id, Motorcycle motorcycle){
        Motorcycle motorcycleToUpdate = motorcycles.stream().filter(m -> m.getId() == id).findFirst().orElse(null);
        if (motorcycleToUpdate == null) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "No se encontró la motocicleta con el ID proporcionado");
        }
        motorcycleToUpdate.setBrand(motorcycle.getBrand());
        motorcycleToUpdate.setPrice(motorcycle.getPrice());
        motorcycleToUpdate.setSnid(motorcycle.getSnid());
        motorcycleToUpdate.setAbsBrake(motorcycle.isAbsBrake());
        motorcycleToUpdate.setForkType(motorcycle.getForkType());
        motorcycleToUpdate.setHelmetIncluded(motorcycle.isHelmetIncluded());
        motorcycleToUpdate.setArrivalDate(motorcycle.getArrivalDate());

    }
}
