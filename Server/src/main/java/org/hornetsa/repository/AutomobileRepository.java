package org.hornetsa.repository;

import org.hornetsa.model.Automobile;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

@Repository
public interface AutomobileRepository extends JpaRepository<Automobile, Integer> {

        @Query("SELECT a FROM Automobile a WHERE (:absBrake IS NULL OR a.absBrake = :absBrake)")
        List<Automobile> findByAbsBrake(@Param("absBrake") Boolean absBrake);

}
