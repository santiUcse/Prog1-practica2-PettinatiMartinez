namespace TorneoFurbol;

public class Partido
{
    public Equipo Local { get; set; }
    public Equipo Visitante { get; set; }
    public string Fecha { get; set; }
    public bool Jugado { get; set; }

    public int GolesLocal { get; set; }
    public int GolesVisitante { get; set; }

    public Partido(Equipo l, Equipo v, string fecha)
    {
        Local = l;
        Visitante = v;
        Fecha = fecha;
        Jugado = false;
    }

    public void Jugar(int gl, int gv)
    {
        GolesLocal = gl;
        GolesVisitante = gv;
        Jugado = true;

        Local.GolesFavor += gl;
        Local.GolesContra += gv;

        Visitante.GolesFavor += gv;
        Visitante.GolesContra += gl;

        if (gl > gv)
            Local.Puntos += 3;
        else if (gv > gl)
            Visitante.Puntos += 3;
        else
        {
            Local.Puntos += 1;
            Visitante.Puntos += 1;
        }
    }
}