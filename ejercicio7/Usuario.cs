public class Usuario
{
    public string Nombre;
    public string Email;

    public List<Curso> cursos = new List<Curso>();

    public Usuario(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }
}