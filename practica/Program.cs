// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Tarea [] TareasDelDia = new Tarea[5] ;

for (int i = 0; i < TareasDelDia.Length; i++)
{
    TareasDelDia[i] = new Tarea(); //se crea el objeto Tarea --- ejecuto el constructor del objeto tarea
    TareasDelDia[i].Descripcion = $"Saludar{i+1}";
    TareasDelDia[i].FechaLimite = DateTime.Now;
    TareasDelDia[i].IdTarea = i;
    // Console.WriteLine(TareasDelDia[i].Descripcion);
    // Console.WriteLine(TareasDelDia[i].IdTarea);
    // Console.WriteLine(TareasDelDia[i].FechaLimite);
    Console.WriteLine(TareasDelDia[i].ShowTarea());
}
