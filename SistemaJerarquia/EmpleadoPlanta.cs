namespace SistemaJerarquia;

public class EmpleadoPlanta
{
    public string Nombre { get; set; }
    public string Legajo { get; set; }
    public string FechaIngreso { get; set; }
    public double SueldoBase { get; set; }

    public EmpleadoPlanta(string nombre, string legajo, string fecha, double sueldo)
    {
        Nombre = nombre;
        Legajo = legajo;
        FechaIngreso = fecha;
        SueldoBase = sueldo;
    }

    public double Sueldo()
{
    string[] partes = FechaIngreso.Split('-');

    int dia = Convert.ToInt32(partes[0]);
    int mes = Convert.ToInt32(partes[1]);
    int anio = Convert.ToInt32(partes[2]);

    int antiguedad = DateTime.Now.Year - anio;

    return SueldoBase + (SueldoBase * 0.10 * antiguedad);
}
}