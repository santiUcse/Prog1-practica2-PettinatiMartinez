namespace Ejercicio1;

public class Moto : Vehiculo
{
    public bool TieneSidecar { get; set; }

    public Moto(string marca, string modelo, int anio, bool tieneSidecar)
        : base(marca, modelo, anio)
    {
        TieneSidecar = tieneSidecar;
    }

    public override string Describir()
    {
        if (TieneSidecar)
        {
            return base.Describir() + " - con sidecar";
        }
        else    
        {
            return base.Describir() + " - sin sidecar";
        }
    }
}
