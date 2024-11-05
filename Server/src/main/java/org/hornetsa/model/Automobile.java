package org.hornetsa.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;

import java.time.LocalDateTime;

@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
@Entity
@Table(name = "automobile")
public class Automobile {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    private String brand;
    private double price;
    private String snid;
    private boolean absBrake;

    @ManyToOne  // Configura la relación muchos a uno
    @JoinColumn(name = "bodywork_id")  // Columna que almacena la relación en la tabla "automobile"
    private Bodywork bodywork;  // Cambia List<Integer> bodyworks a un solo objeto Bodywork

    private LocalDateTime arrivalDate;
}
