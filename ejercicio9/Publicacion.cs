public class Publicacion
{
    public string Texto;
    public string Fecha;
    public int Likes;

    public Publicacion(string texto, string fecha)
    {
        Texto = texto;
        Fecha = fecha;
        Likes = 0;
    }
}