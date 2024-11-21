package org.hornetsa.controller;

import org.hornetsa.errors.ErrorMessage;
import org.hornetsa.model.Bodywork;
import org.hornetsa.services.BodyworkService;
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
@RequestMapping("/bodyworks")
public class BodyworkController {

    @Autowired
    private BodyworkService bodyworkService;

    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Bodywork Service OK!";
    }

    @GetMapping("/get")
    public ResponseEntity<List<Bodywork>> getAllBodyworks(
            @RequestParam(value = "hasSunroof", required = false) Boolean hasSunroof) {

        List<Bodywork> bodyworks = bodyworkService.getBodyworks(hasSunroof);

        if (bodyworks.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(bodyworks);
    }

    @GetMapping("/search")
    public ResponseEntity<Bodywork> searchBodywork(
            @RequestParam("id") Optional<Integer> id,
            @RequestParam("name") Optional<String> name) {

        Bodywork bodywork = bodyworkService.getBodyworks(id.orElse(-1), name.orElse(null))
                .stream().findFirst().orElse(null);

        if (bodywork == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(bodywork);
    }

    @PostMapping("/add")
    public ResponseEntity<Bodywork> addBodywork(
            @Valid @RequestBody Bodywork bodywork, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        return ResponseEntity.ok(bodyworkService.addBodywork(bodywork));
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteBodywork(@PathVariable("id") int id) {
        bodyworkService.deleteBodywork(id);
        return ResponseEntity.ok("Bodywork deleted");
    }

    @PutMapping("/update/{id}")
    public ResponseEntity<Bodywork> updateBodywork(
            @PathVariable("id") int id,
            @RequestBody Bodywork bodywork, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        return ResponseEntity.ok(bodyworkService.updateBodywork(id, bodywork));
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
