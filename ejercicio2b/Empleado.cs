using System;
namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}

public class Empleado
{
    string nombre;
    string apellido;
    DateTime fechaNac;
    char eCivil;
    DateTime fechaIngreso;
    double sueldoBasico;
    Cargos cargo;

    public global::System.String Nombre { get => nombre; set => nombre = value; }
    public global::System.String Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public global::System.Char ECivil { get => eCivil; set => eCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public global::System.Double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public int Edad
    {
        get
        {
            DateTime ahora = DateTime.Now;
            int anios = ahora.Year - fechaNac.Year;
            if (ahora.Month < fechaNac.Month || (ahora.Month == fechaNac.Month && ahora.Day < fechaNac.Day))
            {
                anios--;
            }
            return anios;
        }
    }
    public int Antiguedad{
        get{
            DateTime ahora = DateTime.Now;
            int anios = ahora.Year - fechaIngreso.Year;
            if (ahora.Month < fechaIngreso.Month || (ahora.Month == fechaIngreso.Month && ahora.Day < fechaIngreso.Day))
            {
                anios--;
            }
            return anios;
        }
    }
    public double Salario{
        get{
            double aPagar = 0;
            double adicional = 0;
            if (Antiguedad <= 20)
            {
                adicional = sueldoBasico * (Antiguedad * 0.01);
            }else
            {
                adicional = sueldoBasico * 0.25;
            }

            if (cargo == Cargos.Especialista || cargo == Cargos.Ingeniero)
            {
                adicional *= 1.5;
            }

            if (eCivil == 'c')
            {
                adicional += 150000;
            }
            aPagar = adicional + sueldoBasico;
            return aPagar;
        }
    }

    public int RestanteJubilacion{
        get
        {
            int anios = 65 - Edad;
            return anios;
        }
    }

    public void CargarDatos(string nombre, string apellido, DateTime fechaNac, char eCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaNac;
        this.eCivil = eCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }
    public string MostrarDatosEmpleado()
    {
        return Nombre + ", " + Apellido + " | " + FechaNac.ToShortDateString() + " | " + SueldoBasico + " | " + Antiguedad +" | "+ Salario+" | "+ Edad + " | " + RestanteJubilacion;
    }
}