using EspacioEmpleado;
using System;

// See https://aka.ms/new-console-template for more information

Empleado empleado = new Empleado();

//solicitar y leer datos de empleados
Console.WriteLine("ingrese datos del empleado");

Console.WriteLine("nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("apellido:");
string apellido = Console.ReadLine();

Console.WriteLine("ingrese estado civil");
char eCivil = char.Parse(Console.ReadLine());

Console.WriteLine("ingrese fecha de Nacimiento:(formato dd/mm/aaaa");
DateTime fechaNac = DateTime.Parse(Console.ReadLine());

Console.WriteLine("ingrese el sueldo :");
double sueldoB = double.Parse(Console.ReadLine());

Console.WriteLine("ingrese fecha de ingreso:");
DateTime fechaI = DateTime.Parse(Console.ReadLine());

Console.WriteLine("ingrese el cargo");
// Cargos cargo;
// Enum.TryParse(Console.ReadLine(), out cargo);
// Convierte la entrada del usuario a un valor del enumerado Cargos, ignorando mayúsculas y minúsculas
Cargos cargo = (Cargos)Enum.Parse(typeof(Cargos),Console.ReadLine(),true);

//carga los datos del empleado.
empleado.CargarDatos(nombre, apellido, fechaNac, eCivil, fechaI, sueldoB, cargo);

//mostrar los datos del empleado
empleado.MostrarDatos();

double sueldoAcobrar = empleado.CalcularSalario();
Console.WriteLine($"Sueldo a cobrar: {sueldoAcobrar}");