public class Tienda
{
    public List<Producto> Productos { get; set; }

    public Tienda()
    {
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto p)
    {
        Productos.Add(p);
    }

    public void VenderProducto(string nombre)
    {
        Producto encontrado = null;

        foreach (Producto p in Productos)
        {
            if (p.Nombre == nombre)
            {
                encontrado = p;
                break;
            }
        }

        if (encontrado != null)
        {
            Productos.Remove(encontrado);
            Console.WriteLine("Producto vendido");
        }
        else
        {
            Console.WriteLine("No existe el producto");
        }
    }

    public void BuscarPorCategoria(string categoria)
    {
        foreach (Producto p in Productos)
        {
            if (p.Categoria == categoria)
            {
                Console.WriteLine(p.Nombre + " - " + p.Precio);
            }
        }
    }

    public double ValorInventario()
    {
        double total = 0;

        foreach (Producto p in Productos)
        {
            total += p.Precio;
        }

        return total;
    }
}