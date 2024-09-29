package org.hornetsa.services;

import org.hornetsa.model.Motorcycle;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.ArrayList;

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

    public void setMotorcycle(Motorcycle motorcycle) {
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
}
