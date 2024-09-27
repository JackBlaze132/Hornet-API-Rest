package com.example.MSStudent.controller;


import com.example.MSStudent.errors.ErrorMessage;
import com.example.MSStudent.model.Estudiante;
import com.example.MSStudent.services.StudentService;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.BindingResult;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.server.ResponseStatusException;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Optional;
import java.util.stream.Collectors;

@RestController
@RequestMapping(value = "/estudiantes")
public class StudentController {

    private static String codigo = "2220201001";


    @RequestMapping(value = "/healthcheck")
    public String healthCheck(){
        return "Student Service OK!";
    }

    /*
    @GetMapping(value = "/")
    public String getCodigo(){
        return codigo;
    }
*/
    @GetMapping(value = "/")
    public ResponseEntity<Estudiante> getEstudiante(){
        StudentService studentService = StudentService.getStudentService();

        Estudiante estudiante= studentService.getEstudiante();
        /*
        Estudiante estudiante = Estudiante.builder()
                .codigo(12345)
                .nombre("Carlos")
                .build();
        */

        if (estudiante == null) return ResponseEntity.notFound().build();

        return ResponseEntity.ok(estudiante);
    }

    /*
    @PostMapping(value = "/{codigo}")
    public void setCodigo(@PathVariable("codigo") String codigo){
        this.codigo = codigo;
    }
    */

    @PostMapping
    public ResponseEntity<Estudiante> setCodigo(@RequestBody Estudiante estudiante, BindingResult result){
        if (result.hasErrors()){
            throw new ResponseStatusException(HttpStatus.BAD_REQUEST,
                    this.formatMessage(result));
        }

        try {
            StudentService studentService = StudentService.getStudentService();
            studentService.setEstudiante(estudiante);
        } catch (Exception e){
            return ResponseEntity.badRequest().build();
        }

        return ResponseEntity.ok(estudiante);
    }


    @PostMapping(value = "/add")
    public void setCodigo2(@RequestParam("codigo") Optional<String> codigo){
        this.codigo = codigo.isPresent() ? codigo.get() : this.codigo;
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


}
