namespace AgendaTurnos;

public class Turno
{
    public string Fecha { get; set; }
    public string Hora { get; set; }
    public string Cliente { get; set; }
    public string Servicio { get; set; }

    public Turno(string fecha, string hora, string cliente, string servicio)
    {
        Fecha = fecha;
        Hora = hora;
        Cliente = cliente;
        Servicio = servicio;
    }
}