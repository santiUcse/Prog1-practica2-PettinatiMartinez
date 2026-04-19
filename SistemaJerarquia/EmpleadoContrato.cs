namespace SistemaJerarquia;
public class EmpleadoContrato
{
    public string Nombre { get; set; }
    public string Legajo { get; set; }
    public string FechaIngreso { get; set; }
    public double ValorHora { get; set; }
    public int Horas { get; set; }

    public EmpleadoContrato(string nombre, string legajo, string fecha, double valorHora, int horas)
    {
        Nombre = nombre;
        Legajo = legajo;
        FechaIngreso = fecha;
        ValorHora = valorHora;
        Horas = horas;
    }

    public double Sueldo()
    {
        return ValorHora * Horas;
    }
}