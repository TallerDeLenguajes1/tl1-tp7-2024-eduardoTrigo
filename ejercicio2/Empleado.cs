using System;

namespace EspacioEmpleado;

public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public void CargarDatos(string nombre, string apellido,DateTime fechaN,char eCivil,DateTime fechaI, double sueldoB, Cargos cargo){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaN;
        this.estadoCivil = eCivil;
        this.fechaIngreso = fechaI;
        this.sueldoBasico = sueldoB;
        this.cargo = cargo;
    }

    public void MostrarDatos(){
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Apellido: {apellido}");
        Console.WriteLine($"fecha de nacimiento: {fechaNac.ToString("dd/mm/yyyy")}");
        Console.WriteLine($"Estado civil: {estadoCivil}");
        Console.WriteLine($"fecha de ingreso: {fechaIngreso.ToString("dd/mm/yyyy")}");
        Console.WriteLine($"Sueldo Basico : {sueldoBasico}");
        Console.WriteLine($"Cargo : {cargo}");
    }
}