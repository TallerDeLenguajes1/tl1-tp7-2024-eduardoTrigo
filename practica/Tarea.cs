// See https://aka.ms/new-console-template for more information


// < Tipo de dato > [] nombreDelArreglo

public class Tarea{
    int idTarea;
    DateTime fechaLimite;
    String descripcion;

    public int IdTarea { get => idTarea; set => idTarea = value; }
    public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }

    public string ShowTarea(){
        return IdTarea +" | "+ FechaLimite.ToShortDateString() +" | "+Descripcion;
    }
}