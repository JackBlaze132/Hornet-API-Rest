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

    private static String id = "1";


    @RequestMapping("/healthcheck")
    public String healthCheck(){
        return "motorcycle Service OK!";
    }

    @GetMapping("/get")
    public ResponseEntity<ArrayList<Motorcycle>> getMotorcycle(){
        MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();

        ArrayList<Motorcycle> motorcycles = motorcycleService.getMotorcycles();

        if (motorcycles == null || motorcycles.isEmpty()) return ResponseEntity.notFound().build();



        return ResponseEntity.ok(motorcycles);
    }

    @PostMapping("/add")
    public ResponseEntity<Motorcycle> setId(@RequestBody Motorcycle motorcycle, BindingResult result){
        if (result.hasErrors()){
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST,
                    this.formatMessage(result));
        }

        try {
            MotorcycleService motorcycleService = MotorcycleService.getMotorcycleService();
            motorcycleService.setMotorcycle(motorcycle);
        } catch (Exception e){
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(motorcycle);
    }


    /*@PostMapping(value = "/adds")
    public void setId(@RequestParam("id") Optional<String> id){
        this.id = id.isPresent() ? id.get() : this.id;
    }*/


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


}
