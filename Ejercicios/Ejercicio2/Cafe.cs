namespace Ejercicio2;

public class Cafe : Bebida
{
    public bool TieneLeche { get; set;}

    public Cafe(string nombre, decimal precio, bool tieneLeche) 
        : base(nombre, precio) {
        TieneLeche = tieneLeche;
    }

    public override string Preparar(){
        return "pone agua en el cafe y se hace";
    }

}
