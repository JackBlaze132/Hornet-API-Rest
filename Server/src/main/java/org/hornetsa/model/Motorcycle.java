package org.hornetsa.model;

import jakarta.persistence.*;
import jakarta.validation.constraints.*;

import java.time.LocalDateTime;

@Entity
@Table(name = "motorcycle")
public class Motorcycle {

    @Id
    @Min(value = 1, message = "ID must be greater than 0")
    private int id;

    @NotNull(message = "Brand cannot be null")
    @Size(min = 2, max = 50, message = "Brand must be between 2 and 50 characters")
    private String brand;

    @NotNull(message = "Price cannot be null")
    @Positive(message = "Price must be a positive value")
    private double price;

    @NotNull(message = "SNID cannot be null")
    @Size(min = 3, max = 20, message = "SNID must be between 5 and 20 characters")
    private String snid;

    private boolean absBrake;

    @NotNull(message = "ForkType cannot be null")
    @Size(max = 30, message = "Fork type must be at most 30 characters")
    private String forkType;

    private boolean helmetIncluded;

    @NotNull(message = "Time cannot be null")
    @PastOrPresent(message = "Arrival date cannot be in the future")
    private LocalDateTime arrivalDate;

    // Constructor, getters y setters

    public Motorcycle() {}

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String getSnid() {
        return snid;
    }

    public void setSnid(String snid) {
        this.snid = snid;
    }

    public boolean isAbsBrake() {
        return absBrake;
    }

    public void setAbsBrake(boolean absBrake) {
        this.absBrake = absBrake;
    }

    public String getForkType() {
        return forkType;
    }

    public void setForkType(String forkType) {
        this.forkType = forkType;
    }

    public boolean isHelmetIncluded() {
        return helmetIncluded;
    }

    public void setHelmetIncluded(boolean helmetIncluded) {
        this.helmetIncluded = helmetIncluded;
    }

    public LocalDateTime getArrivalDate() {
        return arrivalDate;
    }

    public void setArrivalDate(LocalDateTime arrivalDate) {
        this.arrivalDate = arrivalDate;
    }
}
