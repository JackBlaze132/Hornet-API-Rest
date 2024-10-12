package org.hornetsa.controller;

import org.hornetsa.errors.ErrorMessage;
import org.hornetsa.model.Bodywork;
import org.hornetsa.services.BodyworkService;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.*;
import java.util.stream.Collectors;

@RestController
@RequestMapping("/bodyworks")
public class BodyworkController {

    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Bodywork Service OK!";
    }

    @GetMapping("/get")
    public ResponseEntity<ArrayList<Bodywork>> getAllBodyworks() {
        BodyworkService bodyworkService = BodyworkService.getBodyworkService();

        ArrayList<Bodywork> bodyworks = bodyworkService.getBodyworks();

        if (bodyworks == null || bodyworks.isEmpty()) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(bodyworks);
    }

    @GetMapping("/search")
    public ResponseEntity<Bodywork> searchBodywork(@RequestParam("id") Optional<Integer> id, @RequestParam("name") Optional<String> name) {
        BodyworkService bodyworkService = BodyworkService.getBodyworkService();

        Bodywork bodywork = bodyworkService.getBodyworks(id.orElse(-1), name.orElse(null)).stream().findFirst().orElse(null);

        if (bodywork == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(bodywork);
    }

    @PostMapping("/add")
    public ResponseEntity<Bodywork> addBodywork(@RequestBody Bodywork bodywork, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            BodyworkService bodyworkService = BodyworkService.getBodyworkService();
            bodyworkService.postBodywork(bodywork);
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(bodywork);
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteBodywork(@PathVariable("id") int id) {
        BodyworkService bodyworkService = BodyworkService.getBodyworkService();
        bodyworkService.deleteBodywork(id);
        return ResponseEntity.ok("Carrocería eliminada");
    }

    @PutMapping("/update/{id}")
    public ResponseEntity<Bodywork> updateBodywork(@PathVariable("id") int id, @RequestBody Bodywork bodywork, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            BodyworkService bodyworkService = BodyworkService.getBodyworkService();
            bodyworkService.update(id, bodywork);
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(bodywork);
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

    // Método para agregar múltiples carrocerías
    @PostMapping("/addMultiple")
    public ResponseEntity<List<Bodywork>> addBodyworks(@RequestBody List<Bodywork> bodyworks, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        BodyworkService bodyworkService = BodyworkService.getBodyworkService();

        List<Bodywork> createdBodyworks = new ArrayList<>();

        try {
            for (Bodywork bodywork : bodyworks) {
                bodyworkService.postBodywork(bodywork); // Guarda cada carrocería
                createdBodyworks.add(bodywork); // Añade la carrocería creada a la lista de respuesta
            }
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(createdBodyworks);
    }
}
