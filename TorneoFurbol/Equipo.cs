namespace TorneoFurbol;

public class Equipo
{
    public string Nombre { get; set; }
    public string DT { get; set; }
    public List<Jugador> Jugadores { get; set; }

    public int Puntos { get; set; }
    public int GolesFavor { get; set; } 
    public int GolesContra { get; set; }

    public Equipo(string nombre, string dt)
    {
        Nombre = nombre;
        DT = dt; //inasio pagiari
        Jugadores = new List<Jugador>();
        Puntos = 0;
    }

    public int DiferenciaGoles()
    {
        return GolesFavor - GolesContra;
    }
}
