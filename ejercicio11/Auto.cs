public class Auto : Vehiculo
{
    public int Puertas;
    public string Combustible;

    public Auto(string marca, string modelo, int anio, double precio, int puertas, string combustible)
        : base(marca, modelo, anio, precio)
    {
        Puertas = puertas;
        Combustible = combustible;
    }

    public override string Describir()
    {
        return base.Describir() + " - " + Puertas + " puertas - " + Combustible;
    }
}