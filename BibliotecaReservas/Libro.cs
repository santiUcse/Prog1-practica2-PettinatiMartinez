namespace BibliotecaReservas;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int Ejemplares { get; set; }
    public int Prestamos { get; set; }

    public Queue<Usuario> Reservas { get; set; }

    public Libro(string titulo, string autor, string isbn, int ej)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Ejemplares = ej;
        Prestamos = 0;
        Reservas = new Queue<Usuario>();
    }

    public bool Disponible()
    {
        return Ejemplares > 0;
    }
}