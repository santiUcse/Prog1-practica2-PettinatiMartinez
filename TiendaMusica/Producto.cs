public class Producto
{
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, string categoria, double precio)
    {
        Nombre = nombre;
        Categoria = categoria;
        Precio = precio;
    }
}