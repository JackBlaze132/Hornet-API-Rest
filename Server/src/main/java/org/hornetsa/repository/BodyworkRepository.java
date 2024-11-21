package org.hornetsa.repository;

import org.hornetsa.model.Bodywork;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface BodyworkRepository extends JpaRepository<Bodywork, Integer> {

    @Query("SELECT b FROM Bodywork b WHERE (:hasSunroof IS NULL OR b.hasSunroof = :hasSunroof)")
    List<Bodywork> findByHasSunroof(@Param("hasSunroof") Boolean hasSunroof);

    @Query("SELECT b FROM Bodywork b " +
            "WHERE (:id = 0 OR b.id = :id) " +
            "AND (:name IS NULL OR b.name = :name)")
    List<Bodywork> findByIdAndName(@Param("id") int id, @Param("name") String name);

}
