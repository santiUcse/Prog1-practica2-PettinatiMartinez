namespace Ejercicio2;

public class Jugo : Bebida
{
    public string Fruta { get; set; }

    public Jugo(string nombre, decimal precio, string fruta) 
        : base(nombre, precio)
    {
        Fruta = fruta;
    }

    public override string Preparar()
    {
        return $"Preparando jugo de {Fruta}";
    }
}
