package org.hornetsa.controller;

import org.hornetsa.errors.ErrorMessage;
import org.hornetsa.model.Automobile;
import org.hornetsa.services.AutomobileService;
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
@RequestMapping("/automobiles")
public class AutomobileController {

    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Automobile Service OK!";
    }

    @GetMapping("/get")
    public ResponseEntity<ArrayList<Automobile>> getAllAutomobiles() {
        AutomobileService automobileService = AutomobileService.getAutomobileService();

        ArrayList<Automobile> automobiles = automobileService.getAutomobiles();

        if (automobiles == null || automobiles.isEmpty()) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(automobiles);
    }

    @GetMapping("/search")
    public ResponseEntity<Automobile> searchAutomobile(@RequestParam("id") Optional<Integer> id, @RequestParam("snid") Optional<String> snid) {
        AutomobileService automobileService = AutomobileService.getAutomobileService();

        Automobile automobile = automobileService.getAutomobiles(id.orElse(-1), snid.orElse(null)).stream().findFirst().orElse(null);

        if (automobile == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(automobile);
    }

    @PostMapping("/add")
    public ResponseEntity<Automobile> addAutomobile(@RequestBody Automobile automobile, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            AutomobileService automobileService = AutomobileService.getAutomobileService();
            automobileService.postAutomobile(automobile);
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(automobile);
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteAutomobile(@PathVariable("id") int id) {
        AutomobileService automobileService = AutomobileService.getAutomobileService();
        automobileService.deleteAutomobile(id);
        return ResponseEntity.ok("Automóvil eliminado");
    }

    @PutMapping("/update/{id}")
    public ResponseEntity<Automobile> updateAutomobile(@PathVariable("id") int id, @RequestBody Automobile automobile, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            AutomobileService automobileService = AutomobileService.getAutomobileService();
            automobileService.update(id, automobile);
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(automobile);
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

    // Método para agregar múltiples automóviles
    @PostMapping("/addMultiple")
    public ResponseEntity<List<Automobile>> addAutomobiles(@RequestBody List<Automobile> automobiles, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        AutomobileService automobileService = AutomobileService.getAutomobileService();

        List<Automobile> createdAutomobiles = new ArrayList<>();

        try {
            for (Automobile automobile : automobiles) {
                automobileService.postAutomobile(automobile); // Guarda cada automóvil
                createdAutomobiles.add(automobile); // Añade el automóvil creado a la lista de respuesta
            }
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(createdAutomobiles);
    }
}
