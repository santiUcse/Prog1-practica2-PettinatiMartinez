

public class Gimnasio
{
    public List<Socio> Socios { get; set; }
    public List<Actividad> Actividades { get; set; }

    public Gimnasio()
    {
        Socios = new List<Socio>();
        Actividades = new List<Actividad>();
    }

    public void AgregarSocio(Socio socio)
    {
        Socios.Add(socio);
    }

    public void AgregarActividad(Actividad actividad)
    {
        Actividades.Add(actividad);
    }
}