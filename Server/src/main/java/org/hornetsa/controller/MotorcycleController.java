package org.hornetsa.controller;

import org.hornetsa.errors.ErrorMessage;
import org.hornetsa.model.Motorcycle;
import org.hornetsa.services.MotorcycleService;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import jakarta.validation.Valid; // Importar @Valid
import java.util.*;

@RestController
@RequestMapping("/motorcycles")
public class MotorcycleController {

    @Autowired
    private MotorcycleService motorcycleService;

    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Motorcycle Service OK!";
    }

    @GetMapping("/get")
    public ResponseEntity<List<Motorcycle>> getAllMotorcycles(
            @RequestParam(value = "helmetIncluded", required = false) Boolean helmetIncluded,
            @RequestParam(value = "absBrake", required = false) Boolean absBrake) {

        List<Motorcycle> motorcycles = motorcycleService.getMotorcycles();

        if (helmetIncluded != null) {
            motorcycles = motorcycles.stream()
                    .filter(m -> m.isHelmetIncluded() == helmetIncluded)
                    .toList();
        }

        if (absBrake != null) {
            motorcycles = motorcycles.stream()
                    .filter(m -> m.isAbsBrake() == absBrake)
                    .toList();
        }

        if (motorcycles.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(motorcycles);
    }

    @GetMapping("/search")
    public ResponseEntity<Motorcycle> searchMotorcycle(
            @RequestParam("id") Optional<Integer> id,
            @RequestParam("snid") Optional<String> snid) {

        Motorcycle motorcycle = motorcycleService.getMotorcycles().stream()
                .filter(m -> (id.isPresent() && m.getId() == id.get()) ||
                        (snid.isPresent() && m.getSnid().equals(snid.get())))
                .findFirst()
                .orElse(null);

        if (motorcycle == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(motorcycle);
    }

    @PostMapping("/add")
    public ResponseEntity<Motorcycle> addMotorcycle(
            @Valid @RequestBody Motorcycle motorcycle, BindingResult result) {  // @Valid agregado

        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        return ResponseEntity.ok(motorcycleService.addMotorcycle(motorcycle));
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteMotorcycle(@PathVariable("id") int id) {
        motorcycleService.deleteMotorcycle(id);
        return ResponseEntity.ok("Motorcycle deleted");
    }

    @PutMapping("/update/{id}")
    public ResponseEntity<Motorcycle> updateMotorcycle(
            @PathVariable("id") int id,
            @RequestBody Motorcycle motorcycle, BindingResult result) {  // @Valid agregado

        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        return ResponseEntity.ok(motorcycleService.updateMotorcycle(id, motorcycle));
    }

    private String formatMessage(BindingResult result) {
        List<Map<String, String>> errores = result.getFieldErrors().stream()
                .map(err -> {
                    Map<String, String> error = new HashMap<>();
                    error.put(err.getField(), err.getDefaultMessage());
                    return error;
                }).toList();

        ErrorMessage errorMessage = ErrorMessage.builder()
                .code("01")
                .mensajes(errores)
                .build();

        ObjectMapper mapper = new ObjectMapper();
        String jsonString = "";
        try {
            jsonString = mapper.writeValueAsString(errorMessage);
        } catch (JsonProcessingException e) {
            e.printStackTrace();
        }

        return jsonString;
    }
}
