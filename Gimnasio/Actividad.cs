
public class Actividad
{
    public string Nombre { get; set; }
    public int CupoMaximo { get; set; }
    public List<Socio> Inscriptos { get; set; }

    public Actividad(string nombre, int cupo)
    {
        Nombre = nombre;
        CupoMaximo = cupo;
        Inscriptos = new List<Socio>();
    }

    public bool AgregarSocio(Socio socio)
    {
        if (Inscriptos.Count < CupoMaximo && socio.CuotaAlDia)
        {
            Inscriptos.Add(socio);
            return true;
        }
        return false;
    }
}