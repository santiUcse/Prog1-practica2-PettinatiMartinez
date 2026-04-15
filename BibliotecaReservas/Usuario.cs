namespace BibliotecaReservas;

public class Usuario
{
    public string Nombre { get; set; }
    public string DNI { get; set; }
    public List<string> Prestamos { get; set; }

    public Usuario(string nombre, string dni)
    {
        Nombre = nombre;
        DNI = dni;
        Prestamos = new List<string>();
    }

    public bool TieneLibro(string isbn)
    {
        return Prestamos.Contains(isbn);
    }
}