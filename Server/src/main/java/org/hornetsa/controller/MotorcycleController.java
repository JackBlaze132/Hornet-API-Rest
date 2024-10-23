package org.hornetsa.controller;


import org.hornetsa.errors.ErrorMessage;
import org.hornetsa.model.Motorcycle;
import org.hornetsa.services.MotorcycleService;
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
@RequestMapping("/motorcycles")
public class MotorcycleController {



    @RequestMapping("/healthcheck")
    public String healthCheck(){
        return "motorcycle Service OK!";
    }

    @GetMapping
    public ResponseEntity<List<Motorcycle>> getAllMotorcycles(@RequestParam(value = "helmetIncluded", required = false) Boolean helmetIncluded, @RequestParam(value = "absBrake", required = false) Boolean absBrake) {
        MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();

        // Obtener la lista completa de motocicletas
        List<Motorcycle> motorcycles = motorcycleService.getMotorcycles();

        // Filtrar por casco incluido si se especifica
        if (helmetIncluded != null) {
            motorcycles = motorcycles.stream()
                    .filter(m -> m.isHelmetIncluded() == helmetIncluded)
                    .collect(Collectors.toList());
        }

        // Filtrar por frenos ABS si se especifica
        if (absBrake != null) {
            motorcycles = motorcycles.stream()
                    .filter(m -> m.isAbsBrake() == absBrake)
                    .collect(Collectors.toList());
        }

        // Verificar si la lista resultante está vacía
        if (motorcycles.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(motorcycles);
    }


    @GetMapping("/search")
    public ResponseEntity<Motorcycle> searchMotorcycle(@RequestParam("id") Optional<Integer> id, @RequestParam("snid") Optional<String> snid){
        MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();

        Motorcycle motorcycle = motorcycleService.getMotorcycle(id.orElse(-1), snid.orElse(null)).stream().findFirst().orElse(null);

        if (motorcycle == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(motorcycle);
    }


    @PostMapping("/add")
    public ResponseEntity<Motorcycle> addMotorcycle(@RequestBody Motorcycle motorcycle, BindingResult result){
        if (result.hasErrors()){
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST,
                    this.formatMessage(result));
        }

        try {
            MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();
            motorcycleService.postMotorcycle(motorcycle);
        } catch (Exception e){
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(motorcycle);
    }


    /*@PostMapping(value = "/adds")
    public void setId(@RequestParam("id") Optional<String> id){
        this.id = id.isPresent() ? id.get() : this.id;
    }*/

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteMotorcycle(@PathVariable("id") int id){
        MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();
        motorcycleService.deleteMotorcycle(id);
        return ResponseEntity.ok("Motocicleta eliminada");
    }

    @PutMapping("/update/{id}")
    public ResponseEntity<Motorcycle> updateMotorcycle(@PathVariable("id") int id,  @RequestBody Motorcycle motorcycle, BindingResult result){
        if (result.hasErrors()){
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST,
                    this.formatMessage(result));
        }

        try {
            MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();
            motorcycleService.update(id, motorcycle);
        } catch (Exception e){
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(motorcycle);
    }


    private String formatMessage(BindingResult result){
        List<Map<String,String>> errores = result.getFieldErrors().stream()
                .map(err -> {
                    Map<String,String> error = new HashMap<>();
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

    //TEST METHOD QA
    @PostMapping("/addMultiple")
    public ResponseEntity<List<Motorcycle>> addMotorcycles(@RequestBody List<Motorcycle> motorcycles, BindingResult result) {
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();

        List<Motorcycle> createdMotorcycles = new ArrayList<>();

        try {
            for (Motorcycle motorcycle : motorcycles) {
                motorcycleService.postMotorcycle(motorcycle); // Llama al servicio para guardar cada motocicleta
                createdMotorcycles.add(motorcycle); // Añade la motocicleta creada a la lista de respuesta
            }
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(createdMotorcycles);
    }
    
}
