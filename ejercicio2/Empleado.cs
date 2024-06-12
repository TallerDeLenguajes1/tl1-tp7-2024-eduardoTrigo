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

    public int Antiguedad{
        get
        {
            DateTime ahora = DateTime.Now ;
            int anios = ahora.Year - fechaIngreso.Year;
            if (ahora.Month < fechaIngreso.Month || (ahora.Month == fechaIngreso.Month && ahora.Day < fechaIngreso.Day))
            {
                anios --;
            }
            return anios;
        }
    }

    public int Edad{
        get
        {
            DateTime ahora = DateTime.Now;
            int anios = ahora.Year - fechaNac.Year;
            if (ahora.Month < fechaNac.Month || (ahora.Month == fechaNac.Month && ahora.Day < fechaNac.Day))
            {
                anios --;
            }
            return anios;
        }
    }

    public int RestantesParaJubilacion{
        get
        {
            int aniosRestantes = 65 - Edad;
            return aniosRestantes;
        }
    }

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
        Console.WriteLine($"Antiguedad : {Antiguedad}");
        Console.WriteLine($"Años : {Edad}");
        Console.WriteLine($"Años para la jubilacion : {RestantesParaJubilacion}");
    }

    // public double porcentajeAntiguedad(int Antiguedad){
    //     double porcentajeAntiguedad = 0;
    //     if (Antiguedad <= 20)
    //     {
    //         porcentajeAntiguedad = Antiguedad * 0.01;
    //     }else{
    //         porcentajeAntiguedad = 0.25;
    //     }
    //     return porcentajeAntiguedad;
    // }



    // public double CalcularAdicional(int Antiguedad, Cargos cargo){
    //     double adicional = porcentajeAntiguedad(Antiguedad);
    //     if (cargo == Ingeniero || cargo == Especialista)
    //     {
    //         adicional *= 0.5;
    //     }
    //     return adicional;
    // }

    // public double CalcularSalario(double sueldoBasico, )

    public double CalcularSalario(){
        double adicional = 0;
        if (Antiguedad <= 20)
        {
            adicional = sueldoBasico * (Antiguedad * 0.01);
        }else{
            adicional = sueldoBasico *0.25;
        }

        if (cargo == Cargos.Especialista|| cargo == Cargos.Ingeniero)
        {
            adicional *= 1.5;
        }

        if (estadoCivil == 'c')
        {
            adicional += 150000;
        }

        return sueldoBasico + adicional;
    }
}