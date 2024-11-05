package org.hornetsa;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

@SpringBootApplication// Asegúrate de que incluya todos tus paquetes
@EntityScan(basePackages = "org.hornetsa.model")  // Escanea el paquete donde están tus entidades
@EnableJpaRepositories(basePackages = "org.hornetsa.repository")  // Escanea el paquete de tus repositorios

public class Main {

	public static void main(String[] args) {
		SpringApplication.run(Main.class, args);
	}

}
