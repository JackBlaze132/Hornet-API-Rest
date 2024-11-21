package org.hornetsa.controller;

import org.hornetsa.errors.ErrorMessage;
import org.hornetsa.model.Automobile;
import org.hornetsa.services.AutomobileService;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.*;
import java.util.stream.Collectors;
import jakarta.validation.Valid;

@RestController
@RequestMapping("/automobiles")
public class AutomobileController {

    // Inyecta la instancia de AutomobileService
    @Autowired
    private AutomobileService automobileService;

    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Automobile Service OK!";
    }

    @GetMapping("/get")
    public ResponseEntity<List<Map<String, Object>>> getAllAutomobiles(
            @RequestParam(value = "absBrake", required = false) Boolean absBrake) {

        List<Map<String, Object>> automobiles = automobileService.getAutomobiles(absBrake);

        if (automobiles.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(automobiles);
    }

    @GetMapping("/search")
    public ResponseEntity<List<Map<String, Object>>> searchAutomobile(
            @RequestParam(value = "id", defaultValue = "0") int id,
            @RequestParam(value = "snid", required = false) String snid) {

        List<Map<String, Object>> automobiles = automobileService.getAutomobile(id, snid);

        if (automobiles.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(automobiles);
    }

    @PostMapping("/add")
    public ResponseEntity<Automobile> addAutomobile(
            @Valid @RequestBody Automobile automobile, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        return ResponseEntity.ok(automobileService.postAutomobile(automobile));
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteAutomobile(@PathVariable("id") int id) {
        try {
            automobileService.deleteAutomobile(id);
            return ResponseEntity.ok("Automóvil eliminado");
        } catch (Exception e) {
            return ResponseEntity.badRequest().body("Error eliminando el automóvil");
        }
    }

    @PutMapping("/update/{id}")
    public ResponseEntity<Automobile> updateAutomobile(
            @PathVariable("id") int id,
            @RequestBody Automobile automobile, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        return ResponseEntity.ok(automobileService.update(id, automobile));
    }

    private String formatMessage(BindingResult result) {
        List<Map<String, String>> errores = result.getFieldErrors().stream()
                .map(err -> {
                    Map<String, String> error = new HashMap<>();
                    error.put(err.getField(), err.getDefaultMessage());
                    return error;
                }).collect(Collectors.toList());

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
