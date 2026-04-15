namespace TiendaMusica;

public class Venta
{
    public Cliente Cliente { get; set; }
    public List<Producto> Productos { get; set; }

    public Venta(Cliente cliente)
    {
        Cliente = cliente;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto p)
    {
        Productos.Add(p);
    }

    public double Total()
    {
        double total = 0;
        foreach (Producto p in Productos)
        {
            total += p.Precio;
        }
        return total;
    }
}