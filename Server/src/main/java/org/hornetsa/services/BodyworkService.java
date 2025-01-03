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

    public List<Bodywork> getBodyworks(Boolean hasSunroof) {
        if (hasSunroof != null) {
            return bodyworkRepository.findByHasSunroof(hasSunroof);
        }
        return bodyworkRepository.findAll();
    }

    public Bodywork addBodywork(Bodywork bodywork) {
        if (bodyworkRepository.existsById(bodywork.getId())) {
            throw new IllegalArgumentException("Bodywork ID already exists.");
        }

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

    public Bodywork getBodywork(int id, String name) {
        return bodyworkRepository.findOneByIdAndName(
                id, (name == null || name.trim().isEmpty()) ? null : name
        ).orElse(null); // Devuelve null si no hay resultado
    }

}
