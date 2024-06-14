using EspacioEmpleado;

class Empresa
{
    public static double TotalSalarios(Empleado[] empleados){
        double salarios=0;
        foreach (Empleado empleado in empleados)
        {
            salarios += empleado.Salario;
        }
        return salarios;
    }

    public static void MostrarProximoJubilacion(Empleado[] empleados){
        int indice = 0;
        int pjubil = 65;
        for (int i = 0; i < empleados.Length; i++)
        {
           if (empleados[i].RestanteJubilacion < pjubil)
           {
                pjubil = empleados[i].RestanteJubilacion;
                indice = i;
           }
        }
        Console.WriteLine("Proximo emleado a jubilarse:");
        Console.WriteLine("Nombre: "+empleados[indice].Nombre);
        Console.WriteLine("Apellido: "+empleados[indice].Apellido);
        Console.WriteLine("antiguedad:"+empleados[indice].Antiguedad);
    }
}


