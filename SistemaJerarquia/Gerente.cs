namespace SistemaJerarquia;

public class Gerente
{
    public string Nombre { get; set; }
    public string Legajo { get; set; }
    public string FechaIngreso { get; set; }
    public double SueldoBase { get; set; }
    public double IngresosArea { get; set; }

    public Gerente(string nombre, string legajo, string fecha, double sueldo, double ingresos)
    {
        Nombre = nombre;
        Legajo = legajo;
        FechaIngreso = fecha;
        SueldoBase = sueldo;
        IngresosArea = ingresos;
    }

    public double Sueldo()
    {
        return SueldoBase + (IngresosArea * 0.05);
    }
}