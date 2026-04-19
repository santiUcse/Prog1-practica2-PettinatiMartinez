namespace AgendaTurnos;

public class Peluqeria
{
    public List<Peluquero> Peluqueros { get; set; }

    public Peluqeria()
    {
        Peluqueros = new List<Peluquero>();
    }

    public void AgregarPeluquero(Peluquero p)
    {
        Peluqueros.Add(p);
    }
}