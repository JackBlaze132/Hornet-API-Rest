package org.hornetsa.repository;

import org.hornetsa.model.Automobile;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

@Repository
public interface AutomobileRepository extends JpaRepository<Automobile, Integer> {

    // Encuentra un automóvil por su SNID (número de serie)
    Optional<Automobile> findBySnid(String snid);

    // Encuentra automóviles por marca (marca insensible a mayúsculas)
    List<Automobile> findByBrandIgnoreCase(String brand);

    // Encuentra automóviles por precio menor o igual a un valor dado
    List<Automobile> findByPriceLessThanEqual(double price);

    // Encuentra automóviles por presencia de frenos ABS
    List<Automobile> findByAbsBrake(boolean absBrake);

    // Encuentra automóviles dentro de un rango de fechas de llegada
    List<Automobile> findByArrivalDateBetween(LocalDateTime startDate, LocalDateTime endDate);
}
