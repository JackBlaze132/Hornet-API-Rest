package org.hornetsa.repository;

import org.hornetsa.model.Motorcycle;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface MotorcycleRepository extends JpaRepository<Motorcycle, Integer> {

    // Método para buscar motocicletas por marca, sin importar mayúsculas o minúsculas
    List<Motorcycle> findByBrandIgnoreCase(String brand);
    // Método para buscar motocicletas que tienen o no frenos ABS
    List<Motorcycle> findByAbsBrake(boolean absBrake);
    // Método para buscar motocicletas que incluyen o no casco
    List<Motorcycle> findByHelmetIncluded(boolean helmetIncluded);
    // Método para buscar motocicletas por SNID (número de identificación)
    Optional<Motorcycle> findBySnid(String snid);
    // Método para buscar motocicletas por precio menor a un valor específico
    List<Motorcycle> findByPriceLessThan(double price);
    // Método para buscar motocicletas por tipo de horquilla
    List<Motorcycle> findByForkTypeIgnoreCase(String forkType);
}
