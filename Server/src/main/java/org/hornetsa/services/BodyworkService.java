package org.hornetsa.services;

import org.hornetsa.model.Bodywork;
import org.hornetsa.repository.BodyworkRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Service;
import org.springframework.web.server.ResponseStatusException;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Service
public class BodyworkService {

    @Autowired
    private BodyworkRepository bodyworkRepository;

    public List<Bodywork> getBodyworks() {
        return bodyworkRepository.findAll();
    }

    public Bodywork findBodyworkById(int id) {
        return bodyworkRepository.findById(id)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Bodywork not found"));
    }

    public Bodywork addBodywork(Bodywork bodywork) {
        return bodyworkRepository.save(bodywork);
    }

    public void deleteBodywork(int id) {
        if (!bodyworkRepository.existsById(id)) {
            throw new ResponseStatusException(HttpStatus.NOT_FOUND, "Bodywork not found");
        }
        bodyworkRepository.deleteById(id);
    }

    // Método para actualizar un Bodywork existente por ID
    public Bodywork updateBodywork(int id, Bodywork updatedBodywork) {
        Bodywork existingBodywork = bodyworkRepository.findById(id)
                .orElseThrow(() -> new ResponseStatusException(HttpStatus.NOT_FOUND, "Bodywork not found"));
        existingBodywork.setName(updatedBodywork.getName());
        existingBodywork.setHasSunroof(updatedBodywork.isHasSunroof());
        return bodyworkRepository.save(existingBodywork);
    }

    // Método para obtener Bodyworks filtrados por la disponibilidad de sunroof
    public List<Bodywork> getBodyworksBySunroof(boolean hasSunroof) {
        return bodyworkRepository.findByHasSunroof(hasSunroof);
    }

    // Nuevo método para buscar Bodyworks por ID y/o nombre
    public List<Bodywork> getBodyworks(int id, String name) {
        return bodyworkRepository.findAll().stream()
                .filter(b -> (id == -1 || b.getId() == id) &&
                        (name == null || b.getName().equalsIgnoreCase(name)))
                .collect(Collectors.toList());
    }
}
