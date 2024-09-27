package com.example.MSStudent.service;

import com.example.MSStudent.model.Student;
import org.springframework.stereotype.Service;
import  lombok.*;

@Service
public class StudentService {
    private StudentService studentService;
    private Student student;


    private StudentService(){}
    public StudentService getInstance(){
        if(studentService == null){
            studentService = new StudentService();
        }
        return studentService;
    }

    public Student getStudent(){
        return student;
    }

    pub
}
