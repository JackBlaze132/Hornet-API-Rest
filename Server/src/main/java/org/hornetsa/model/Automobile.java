package org.hornetsa.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;

import java.time.LocalDateTime;
import java.util.List;

@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
@Entity
@Table(name = "automobile")  // Nombre de la tabla en la base de datos
public class Automobile {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    private String brand;
    private double price;
    private String snid;
    private boolean absBrake;

    @ElementCollection  // Mapea la lista de IDs de bodyworks
    @CollectionTable(name = "automobile_bodyworks", joinColumns = @JoinColumn(name = "automobile_id"))
    @Column(name = "bodywork_id")
    private List<Integer> bodyworks;

    private LocalDateTime arrivalDate;

    // Constructor, getters y setters
}
