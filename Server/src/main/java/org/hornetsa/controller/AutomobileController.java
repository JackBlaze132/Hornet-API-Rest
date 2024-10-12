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
@RequestMapping("/automobiles")  // Base path for automobile-related operations
public class AutomobileController {

    // Reference to the singleton instance of AutomobileService
    private final AutomobileService automobileService = AutomobileService.getAutomobileService();

    // Health check endpoint to verify the service is running
    @RequestMapping("/healthcheck")
    public String healthCheck() {
        return "Automobile Service OK!";
    }

    // GET endpoint to retrieve all automobiles
    @GetMapping("/get")
    public ResponseEntity<List<Map<String, Object>>> getAllAutomobiles() {
        List<Map<String, Object>> automobiles = automobileService.getAutomobiles(-1, null);

        // Return 404 if no automobiles found
        if (automobiles.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        // Return the list of automobiles with status 200
        return ResponseEntity.ok(automobiles);
    }

    // GET endpoint to search for automobiles by ID and SNID
    @GetMapping("/search")
    public ResponseEntity<List<Map<String, Object>>> searchAutomobile(
            @RequestParam("id") Optional<Integer> id,  // Optional query parameter for ID
            @RequestParam("snid") Optional<String> snid) {  // Optional query parameter for SNID
        List<Map<String, Object>> automobiles = automobileService.getAutomobiles(id.orElse(-1), snid.orElse(null));

        // Return 404 if no matching automobiles found
        if (automobiles.isEmpty()) {
            return ResponseEntity.notFound().build();
        }

        // Return the search results with status 200
        return ResponseEntity.ok(automobiles);
    }

    // POST endpoint to add a new automobile
    @PostMapping("/add")
    public ResponseEntity<Automobile> addAutomobile(
            @RequestBody Automobile automobile, BindingResult result) {
        // Check for validation errors
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            automobileService.postAutomobile(automobile);  // Add the automobile
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();  // Handle errors gracefully
        }

        return ResponseEntity.ok(automobile);  // Return the added automobile
    }

    // POST endpoint to add multiple automobiles
    @PostMapping("/addMultiple")
    public ResponseEntity<List<Automobile>> addAutomobiles(
            @RequestBody List<Automobile> automobiles, BindingResult result) {
        // Check for validation errors
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        List<Automobile> createdAutomobiles = new ArrayList<>();

        try {
            // Add each automobile to the service
            for (Automobile automobile : automobiles) {
                automobileService.postAutomobile(automobile);
                createdAutomobiles.add(automobile);
            }
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();  // Handle errors gracefully
        }

        return ResponseEntity.ok(createdAutomobiles);  // Return the list of added automobiles
    }

    // DELETE endpoint to delete an automobile by ID
    @DeleteMapping("/delete/{id}")
    public ResponseEntity<String> deleteAutomobile(@PathVariable("id") int id) {
        try {
            automobileService.deleteAutomobile(id);  // Delete the automobile
            return ResponseEntity.ok("Automóvil eliminado");  // Return success message
        } catch (Exception e) {
            return ResponseEntity.badRequest().body("Error eliminando el automóvil");  // Handle errors gracefully
        }
    }

    // PUT endpoint to update an existing automobile
    @PutMapping("/update/{id}")
    public ResponseEntity<Automobile> updateAutomobile(
            @PathVariable("id") int id,  // Path variable for automobile ID
            @RequestBody Automobile automobile, BindingResult result) {
        // Check for validation errors
        if (result.hasErrors()) {
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST, this.formatMessage(result));
        }

        try {
            automobileService.update(id, automobile);  // Update the automobile
        } catch (Exception e) {
            return ResponseEntity.badRequest().build();  // Handle errors gracefully
        }

        return ResponseEntity.ok(automobile);  // Return the updated automobile
    }

    // Helper method to format validation error messages
    private String formatMessage(BindingResult result) {
        List<Map<String, String>> errores = result.getFieldErrors().stream()
                .map(err -> {
                    Map<String, String> error = new HashMap<>();
                    error.put(err.getField(), err.getDefaultMessage());  // Field and error message
                    return error;
                }).collect(Collectors.toList());

        // Create an ErrorMessage object with the collected errors
        ErrorMessage errorMessage = ErrorMessage.builder()
                .code("01")  // Error code
                .mensajes(errores)  // List of error messages
                .build();

        // Convert the error message to JSON string using ObjectMapper
        ObjectMapper mapper = new ObjectMapper();
        String jsonString = "";
        try {
            jsonString = mapper.writeValueAsString(errorMessage);
        } catch (JsonProcessingException e) {
            e.printStackTrace();  // Handle JSON processing errors
        }

        return jsonString;  // Return the formatted error message
    }
}
