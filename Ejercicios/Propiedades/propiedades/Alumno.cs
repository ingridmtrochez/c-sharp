using System;

public class Alumno
{
    public int Id { get; set; }

    public String PrimerNombre { get; set; }

    public String SegundoNombre { get; set; }

    public Alumno(){
        Id = 1;
    }

    public Alumno(int id){
        Id = id;
    }

     public Alumno(string primerNombre, string segundoNombre){
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
    }
}