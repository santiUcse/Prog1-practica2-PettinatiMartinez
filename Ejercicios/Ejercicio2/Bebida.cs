namespace Ejercicio2;

public abstract class Bebida
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Bebida(string nombre, decimal precio)
    {
        if (precio < 0)
        {
            throw new ArgumentException("Errado");
        }
        Nombre = nombre;
        Precio = precio;
    } 

    public abstract string Preparar();
    public string MostrarPrecio() {
        return $"{Nombre}: ${Precio:F2}";
    }
}
