package org.hornetsa.model;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.RequiredArgsConstructor;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;


@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
public class Automobile {
    private int id;
    private String brand;
    private double price;
    private String snid;
    private boolean absBrake;
    private List<Integer> bodyworks;  // Stores the IDs of associated Bodyworks
    private LocalDateTime arrivalDate;
}

