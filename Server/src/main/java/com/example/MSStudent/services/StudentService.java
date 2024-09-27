package com.example.MSStudent.services;

import com.example.MSStudent.model.Estudiante;
import lombok.Data;
import lombok.Getter;
import org.springframework.stereotype.Service;

@Service
public class StudentService {

    private static StudentService studentService;
    private Estudiante estudiante;

    private StudentService(){

    }

    public static StudentService getStudentService(){
        if(studentService == null){
            studentService = new StudentService();
        }

        return studentService;
    }

    public Estudiante getEstudiante() {
        return estudiante;
    }

    public void setEstudiante(Estudiante estudiante) {
        this.estudiante = estudiante;
    }
}
