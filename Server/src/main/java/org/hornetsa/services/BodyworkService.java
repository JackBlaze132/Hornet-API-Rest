package org.hornetsa.services;

import org.hornetsa.model.Bodywork;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class BodyworkService {

    private static BodyworkService bodyworkService;
    private static ArrayList<Bodywork> bodyworks;

    private BodyworkService() {
        bodyworks = new ArrayList<>();
    }

    public static BodyworkService getBodyworkService() {
        if (bodyworkService == null) {
            bodyworkService = new BodyworkService();
        }
        return bodyworkService;
    }

    public ArrayList<Bodywork> getBodyworks() {
        return bodyworks;
    }

    public List<Bodywork> getBodyworks(int id, String name) {
        int defaultId = -1;
        return bodyworks.stream()
                .filter(b -> (id == defaultId || b.getId() == id)
                        && (name == null || b.getName().equalsIgnoreCase(name)))
                .collect(Collectors.toList());
    }

    public void postBodywork(Bodywork bodywork) {
        if (bodyworks == null) {
            bodyworks = new ArrayList<>();
        }

        // Verificar si ya existe una carrocería con el mismo ID o nombre
        if (bodyworks.stream().anyMatch(b -> b.getId() == bodywork.getId() || b.getName().equalsIgnoreCase(bodywork.getName()))) {
            throw new ResponseStatusException(HttpStatus.CONFLICT, "Ya existe una carrocería con el mismo ID o nombre");
        }

        bodyworks.add(bodywork);
        System.out.println(bodywork);
    }

    public void deleteBodywork(int id) {
        bodyworks.removeIf(b -> b.getId() == id);
    }

    public void update(int id, Bodywork bodywork) {
        Bodywork bodyworkToUpdate = bodyworks.stream().filter(b -> b.getId() == id).findFirst().orElse(null);
        if (bodyworkToUpdate == null) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "No se encontró la carrocería con el ID proporcionado");
        }
        bodyworkToUpdate.setName(bodywork.getName());
    }
}