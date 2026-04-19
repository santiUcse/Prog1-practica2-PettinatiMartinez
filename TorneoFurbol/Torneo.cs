namespace TorneoFurbol;

public class Torneo
{
    public string Nombre { get; set; }
    public List<Equipo> Equipos { get; set; }
    public List<Partido> Partidos { get; set; }

    public Torneo(string nombre)
    {
        Nombre = nombre;
        Equipos = new List<Equipo>();
        Partidos = new List<Partido>();
    }

    public void AgregarEquipo(Equipo e)
    {
        Equipos.Add(e);
    }

    public void AgregarPartido(Partido p)
    {
        Partidos.Add(p);
    }

    public void Tabla()
    {
        Equipos.Sort((a, b) =>
        {
            int cmp = b.Puntos.CompareTo(a.Puntos);
            if (cmp == 0)
                cmp = b.DiferenciaGoles().CompareTo(a.DiferenciaGoles());
            if (cmp == 0)
                cmp = a.Nombre.CompareTo(b.Nombre);

            return cmp;
        });

        foreach (Equipo e in Equipos)
        {
            Console.WriteLine(e.Nombre + " - " + e.Puntos + " pts");
        }
    }

    public void Goleador()
    {
        Jugador top = null;

        foreach (Equipo e in Equipos)
        {
            foreach (Jugador j in e.Jugadores)
            {
                if (top == null || j.Goles > top.Goles)
                    top = j;
            }
        }

        if (top != null)
            Console.WriteLine("Goleador: " + top.Nombre + " (" + top.Goles + ")");
    }

    public void Amarillas()
    {
        foreach (Equipo e in Equipos)
        {
            foreach (Jugador j in e.Jugadores)
            {
                if (j.Amarillas > 2)
                    Console.WriteLine(j.Nombre + " - " + j.Amarillas);
            }
        }
    }

    public void Clasificados()
    {
        Tabla();

        if (Equipos.Count >= 2)
        {
            Console.WriteLine("Clasificados:");
            Console.WriteLine(Equipos[0].Nombre);
            Console.WriteLine(Equipos[1].Nombre);
        }
    }
}