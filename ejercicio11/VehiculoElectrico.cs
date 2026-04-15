public class VehiculoElectrico : Vehiculo
{
    public int Autonomia;
    public int TiempoCarga;

    public VehiculoElectrico(string marca, string modelo, int anio, double precio, int autonomia, int tiempoCarga)
        : base(marca, modelo, anio, precio)
    {
        Autonomia = autonomia;
        TiempoCarga = tiempoCarga;
    }

    public override string Describir()
    {
        return base.Describir() + " - " + Autonomia + "km - " + TiempoCarga + "hs carga";
    }
}