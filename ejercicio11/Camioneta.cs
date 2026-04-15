public class Camioneta : Vehiculo
{
    public int Carga;
    public string Traccion;

    public Camioneta(string marca, string modelo, int anio, double precio, int carga, string traccion)
        : base(marca, modelo, anio, precio)
    {
        Carga = carga;
        Traccion = traccion;
    }

    public override string Describir()
    {
        return base.Describir() + " - " + Carga + "kg - " + Traccion;
    }
}