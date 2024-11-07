package org.hornetsa.model;

import jakarta.persistence.*;
import jakarta.validation.constraints.*;
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
    @Min(value = 1, message = "ID must be greater than 0")
    private int id;

    @NotNull(message = "Brand cannot be null")
    @Size(min = 2, max = 50, message = "Brand must be between 2 and 50 characters")
    private String brand;

    @Positive(message = "Price must be a positive value")
    private double price;

    @NotNull(message = "SNID cannot be null")
    @Size(min = 5, max = 20, message = "SNID must be between 5 and 20 characters")
    private String snid;

    private boolean absBrake;

    @ManyToOne
    @JoinColumn(name = "bodywork_id")
    @NotNull(message = "Bodywork cannot be null")
    private Bodywork bodywork;

    @PastOrPresent(message = "Arrival date cannot be in the future")
    private LocalDateTime arrivalDate;
}
