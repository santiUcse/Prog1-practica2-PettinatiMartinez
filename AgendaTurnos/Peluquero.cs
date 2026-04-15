namespace AgendaTurnos;

public class Peluquero
{
    public string Nombre { get; set; }
    public List<Turno> Turnos { get; set; }

    public Peluquero(string nombre)
    {
        Nombre = nombre;
        Turnos = new List<Turno>();
    }

    public void AsignarTurno(Turno t)
    {
        Turnos.Add(t);
    }

    public void CancelarTurno(string fecha, string hora)
    {
        Turno encontrado = null;

        foreach (Turno t in Turnos)
        {
            if (t.Fecha == fecha && t.Hora == hora)
            {
                encontrado = t;
                break;
            }
        }

        if (encontrado != null)
        {
            Turnos.Remove(encontrado);
            Console.WriteLine("Turno cancelado");
        }
        else
        {
            Console.WriteLine("No se encontró el turno");
        }
    }

    public void ListarTurnosPorFecha(string fecha)
    {
        foreach (Turno t in Turnos)
        {
            if (t.Fecha == fecha)
            {
                Console.WriteLine(t.Hora + " - " + t.Cliente + " - " + t.Servicio);
            }
        }
    }

    public bool EstaDisponible(string fecha, string hora)
    {
        foreach (Turno t in Turnos)
        {
            if (t.Fecha == fecha && t.Hora == hora)
            {
                return false;
            }
        }
        return true;
    }
}