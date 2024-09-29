package org.hornetsa.model;


import lombok.*;

import java.time.LocalDateTime;

@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
public class Motorcycle {
    private int id;
    private String brand;
    private double price;
    private String snid;
    private boolean abs;
    private String forkType;
    private boolean helmetIncluded;
    private LocalDateTime arrivalDate;
}
