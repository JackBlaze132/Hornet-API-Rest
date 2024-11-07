package org.hornetsa.repository;

import org.hornetsa.model.Bodywork;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface BodyworkRepository extends JpaRepository<Bodywork, Integer> {
    List<Bodywork> findByHasSunroof(boolean hasSunroof);
}
