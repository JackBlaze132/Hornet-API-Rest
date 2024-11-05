package org.hornetsa.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;
import org.hornetsa.repository.BodyworkRepository;

@RestController
public class DatabaseTestController {

    @Autowired
    private BodyworkRepository bodyworkRepository;

    @GetMapping("/test-db-connection")
    public String testDatabaseConnection() {
        try {
            long count = bodyworkRepository.count(); // Ejecuta una consulta simple
            return "Conexión a la base de datos exitosa. Hay " + count + " registros en la tabla Bodywork.";
        } catch (Exception e) {
            return "Error en la conexión a la base de datos: " + e.getMessage();
        }
    }
}
