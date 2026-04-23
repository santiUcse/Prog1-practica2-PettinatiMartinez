namespace Ejercicio1;

public class Auto : Vehiculo
{
    public int CantPuertas {get;set;}

    public Auto(string marca, string modelo, int anio, int puertas)
        : base(marca, modelo, anio)
    {
        CantPuertas = puertas;
    }

    public override string Describir()
    {
        return base.Describir() + $" - {CantPuertas} puertas";
    }
}
