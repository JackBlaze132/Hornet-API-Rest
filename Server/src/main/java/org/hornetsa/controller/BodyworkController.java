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

@RestController  // Marks this class as a REST controller for Spring
@RequestMapping("/bodyworks")  // Base path for bodywork-related operations
public class BodyworkController {

    // Health check endpoint to verify the service is running
    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Bodywork Service OK!";
    }

    // GET endpoint to retrieve all bodyworks
    @GetMapping("/get")
    public ResponseEntity<ArrayList<Bodywork>> getAllBodyworks() {
        BodyworkService bodyworkService = BodyworkService.getBodyworkService();  // Get singleton instance

        ArrayList<Bodywork> bodyworks = bodyworkService.getBodyworks();  // Retrieve all bodyworks

        // Return 404 if no bodyworks are found
        if (bodyworks == null || bodyworks.isEmpty()) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(bodyworks);  // Return the list of bodyworks with status 200
    }

    // GET endpoint to search for a bodywork by ID or name
    @GetMapping("/search")
    public ResponseEntity<Bodywork> searchBodywork(
            @RequestParam("id") Optional<Integer> id,  // Optional query parameter for ID
            @RequestParam("name") Optional<String> name) {  // Optional query parameter for name
        BodyworkService bodyworkService = BodyworkService.getBodyworkService();

        // Search for a matching bodywork
        Bodywork bodywork = bodyworkService.getBodyworks(id.orElse(-1), name.orElse(null))
                .stream().findFirst().orElse(null);

        // Return 404 if not found
        if (bodywork == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(bodywork);  // Return the found bodywork
    }

    // POST endpoint to add a new bodywork
    @PostMapping("/add")
    public ResponseEntity<Bodywork> addBodywork(
            @RequestBody Bodywork bodywork, BindingResult result) {
        // Check for validation errors
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            BodyworkService bodyworkService = BodyworkService.getBodyworkService();
            bodyworkService.postBodywork(bodywork);  // Add the bodywork
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();  // Handle errors gracefully
        }

        return ResponseEntity.ok(bodywork);  // Return the added bodywork
    }

    // DELETE endpoint to delete a bodywork by ID
    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteBodywork(@PathVariable("id") int id) {
        BodyworkService bodyworkService = BodyworkService.getBodyworkService();
        bodyworkService.deleteBodywork(id);  // Delete the bodywork by ID
        return ResponseEntity.ok("Carrocería eliminada");  // Return success message
    }

    // PUT endpoint to update an existing bodywork
    @PutMapping("/update/{id}")
    public ResponseEntity<Bodywork> updateBodywork(
            @PathVariable("id") int id,  // Path variable for bodywork ID
            @RequestBody Bodywork bodywork, BindingResult result) {
        // Check for validation errors
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            BodyworkService bodyworkService = BodyworkService.getBodyworkService();
            bodyworkService.update(id, bodywork);  // Update the bodywork
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();  // Handle errors gracefully
        }

        return ResponseEntity.ok(bodywork);  // Return the updated bodywork
    }

    // Helper method to format validation error messages into JSON
    private String formatMessage(BindingResult result) {
        List<Map<String, String>> errores = result.getFieldErrors().stream()
                .map(err -> {
                    Map<String, String> error = new HashMap<>();
                    error.put(err.getField(), err.getDefaultMessage());  // Map field to error message
                    return error;
                }).collect(Collectors.toList());

        // Create an ErrorMessage object with the list of errors
        ErrorMessage errorMessage = ErrorMessage.builder()
                .code("01")  // Error code
                .mensajes(errores)  // List of error messages
                .build();

        ObjectMapper mapper = new ObjectMapper();  // JSON object mapper
        String jsonString = "";
        try {
            jsonString = mapper.writeValueAsString(errorMessage);  // Convert to JSON string
        } catch (JsonProcessingException e) {
            e.printStackTrace();  // Handle JSON conversion error
        }

        return jsonString;  // Return the formatted JSON error message
    }

    // POST endpoint to add multiple bodyworks
    @PostMapping("/addMultiple")
    public ResponseEntity<List<Bodywork>> addBodyworks(
            @RequestBody List<Bodywork> bodyworks, BindingResult result) {
        // Check for validation errors
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        BodyworkService bodyworkService = BodyworkService.getBodyworkService();

        List<Bodywork> createdBodyworks = new ArrayList<>();

        try {
            // Add each bodywork to the service
            for (Bodywork bodywork : bodyworks) {
                bodyworkService.postBodywork(bodywork);  // Save the bodywork
                createdBodyworks.add(bodywork);  // Add it to the response list
            }
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();  // Handle errors gracefully
        }

        return ResponseEntity.ok(createdBodyworks);  // Return the list of added bodyworks
    }
}
