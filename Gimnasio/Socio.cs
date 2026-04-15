

public class Socio
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public bool CuotaAlDia { get; set; }

    public Socio(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
        CuotaAlDia = true;
    }

    public void PagarCuota()
    {
        CuotaAlDia = true;
    }

    public void AdeudarCuota()
    {
        CuotaAlDia = false;
    }
}
