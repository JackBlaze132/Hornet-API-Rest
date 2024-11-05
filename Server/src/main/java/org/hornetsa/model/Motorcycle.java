package org.hornetsa.model;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import java.time.LocalDateTime;

@Entity
@Table(name = "motorcycle")
public class Motorcycle {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    private String brand;
    private double price;
    private String snid;
    private boolean absBrake;
    private String forkType;
    private boolean helmetIncluded;
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
