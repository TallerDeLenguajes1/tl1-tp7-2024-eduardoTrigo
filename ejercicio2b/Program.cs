using System;
using EspacioEmpleado;
Console.WriteLine("Hello, World!");

Empleado[] empleados = new Empleado[1];

for (int i = 0; i < empleados.Length; i++)
{
    empleados[i] = new Empleado();
    Console.WriteLine($"ingrese datos del empleado {i + 1}");
    Console.WriteLine("Nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Apellido:");
    string apellido = Console.ReadLine();
    Console.WriteLine("Fecha de nacimiento:");
    DateTime fechaNac = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Estado Civil:");
    char eCivil = char.Parse(Console.ReadLine());
    Console.WriteLine("Fecha de ingreso:");
    DateTime fechaIng = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Sueldo basico:");
    double sueldoBasico = double.Parse(Console.ReadLine());
    Console.WriteLine("Cargo:");
    Cargos cargo = (Cargos)Enum.Parse(typeof(Cargos), Console.ReadLine(), true);

    empleados[i].CargarDatos(nombre, apellido, fechaNac, eCivil, fechaIng, sueldoBasico, cargo);
}

for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine(empleados[i].MostrarDatosEmpleado());
}