public class Curso
{
    public string Titulo;
    public string Descripcion;
    public int Duracion;
    public int Cupo;

    public List<Usuario> usuarios = new List<Usuario>();

    public Curso(string titulo, string descripcion, int duracion, int cupo)
    {
        Titulo = titulo;
        Descripcion = descripcion;
        Duracion = duracion;
        Cupo = cupo;
    }
}