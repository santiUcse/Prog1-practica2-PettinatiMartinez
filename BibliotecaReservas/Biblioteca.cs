namespace BibliotecaReservas;

public class Biblioteca
{
    public List<Libro> Libros { get; set; }

    public Biblioteca()
    {
        Libros = new List<Libro>();
    }

    public Libro Buscar(string isbn)
    {
        foreach (Libro l in Libros)
            if (l.ISBN == isbn)
                return l;

        return null;
    }

    public void AgregarLibro(Libro nuevo)
    {
        Libro existente = Buscar(nuevo.ISBN);

        if (existente != null)
        {
            existente.Ejemplares += nuevo.Ejemplares;
        }
        else
        {
            Libros.Add(nuevo);
        }
    }

    public void Prestar(string isbn, Usuario u)
    {
        Libro l = Buscar(isbn);

        if (l == null) return;

        if (u.TieneLibro(isbn)) return;

        if (l.Disponible())
        {
            l.Ejemplares--;
            l.Prestamos++;
            u.Prestamos.Add(isbn);
        }
    }

    public void Reservar(string isbn, Usuario u)
    {
        Libro l = Buscar(isbn);

        if (l == null) return;

        if (!l.Disponible())
        {
            l.Reservas.Enqueue(u);
        }
    }

    public void Devolver(string isbn, Usuario u)
    {
        Libro l = Buscar(isbn);

        if (l == null) return;

        if (u.Prestamos.Contains(isbn))
        {
            u.Prestamos.Remove(isbn);
            l.Ejemplares++;

            if (l.Reservas.Count > 0)
            {
                Usuario siguiente = l.Reservas.Dequeue();

                siguiente.Prestamos.Add(isbn);
                l.Ejemplares--;
                l.Prestamos++;
            }
        }
    }

    public void Ranking()
    {
        Libros.Sort((a, b) => b.Prestamos.CompareTo(a.Prestamos));

        foreach (Libro l in Libros)
        {
            Console.WriteLine(l.Titulo + " - " + l.Prestamos);
        }
    }
}