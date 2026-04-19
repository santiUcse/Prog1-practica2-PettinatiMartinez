namespace SistemaFacturacion;

public class LineaFactura
{
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }

    public LineaFactura(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }

    public double Subtotal()
    {
        return Producto.Precio * Cantidad;
    }

    public double IVA()
    {
        return Subtotal() * Producto.IVA;
    }
}