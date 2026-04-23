namespace Ejercicio2;

public class Agua : Bebida
{
    public bool EsConGas {get; set;}

    public Agua(string nombre, decimal precio, bool esConGas) 
        : base(nombre, precio) {
        EsConGas = esConGas;
    }

    public override string Preparar() {
        if (EsConGas) {
            return "Tiene gas";
        }
        else return "no tiene gas";
    }
}
