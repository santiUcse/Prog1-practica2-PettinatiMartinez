namespace SistemaJerarquia;

public class Empleado
{
    public string Nombre { get; set; }
    public string Legajo { get; set; }
    public string FechaIngreso { get; set; }

    public Empleado(string nombre, string legajo, string fechaIngreso)
    {
        Nombre = nombre;
        Legajo = legajo;
        FechaIngreso = fechaIngreso;
    }

    public virtual double Sueldo()
    {
        return 0;
    }

    public int Antiguedad()
    {
        int anioIngreso = Convert.ToInt32(FechaIngreso.Substring(0, 4));
        int anioActual = DateTime.Now.Year;
        return anioActual - anioIngreso;
    }
}