namespace ejercicio3;

public abstract class Publicacion
{
    public string Titulo { get; set; }
    public decimal Precio { get; set; }
    public int Anio { get; set; }

    public Publicacion(string titulo, decimal precio, int anio)
    {
        if (precio <= 0){
            throw new ArgumentException("El precio debe ser mayor a cero");
    }
        Titulo = titulo;
        Precio = precio;
        Anio = anio;
    }

    public abstract string Describir();
}