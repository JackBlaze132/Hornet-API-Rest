package com.example.MSStudent.model;


import lombok.*;

@Data
@RequiredArgsConstructor
@AllArgsConstructor
@Builder
public class Estudiante {
    private int codigo;
    @NonNull
    private String nombre;
}
