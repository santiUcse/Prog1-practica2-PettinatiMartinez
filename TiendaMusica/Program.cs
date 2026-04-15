using TiendaMusica;

class Program
{
    static void Main()
    {
        Tienda tienda = new Tienda();

        Console.WriteLine("Ingrese nombre del producto:");
        string nombre = Console.ReadLine() ?? "";

        Console.WriteLine("Ingrese categoria:");
        string categoria = Console.ReadLine() ?? "";

        Console.WriteLine("Ingrese precio:");
        double precio = Convert.ToDouble(Console.ReadLine());

        Producto p = new Producto(nombre, categoria, precio);
        tienda.AgregarProducto(p);

        Console.WriteLine("Ingrese nombre a vender:");
        string vender = Console.ReadLine() ?? "";
        tienda.VenderProducto(vender);

        Console.WriteLine("Buscar categoria:");
        string cat = Console.ReadLine() ?? "";
        tienda.BuscarPorCategoria(cat);

        Console.WriteLine("Valor total inventario: " + tienda.ValorInventario());
    }
}