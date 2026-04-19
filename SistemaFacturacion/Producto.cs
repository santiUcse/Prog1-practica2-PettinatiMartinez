namespace SistemaFacturacion;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public double IVA { get; set; }

    public Producto(string nombre, double precio, double iva)
    {
        Nombre = nombre;
        Precio = precio;
        IVA = iva;
    }
}