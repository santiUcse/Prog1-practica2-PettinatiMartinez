using System;

public class Plataforma
{
    public void Inscribir(Usuario u, Curso c)
    {
        if (c.usuarios.Count >= c.Cupo)
        {
            Console.WriteLine("Curso lleno");
            return;
        }

        if (c.usuarios.Contains(u))
        {
            Console.WriteLine("Ya inscripto");
            return;
        }

        c.usuarios.Add(u);
        u.cursos.Add(c);

        Console.WriteLine("Inscripto OK");
    }

    public void DarDeBaja(Usuario u, Curso c)
    {
        c.usuarios.Remove(u);
        u.cursos.Remove(c);

        Console.WriteLine("Baja OK");
    }

    public int HorasTotales(Usuario u)
    {
        int total = 0;

        foreach (Curso c in u.cursos)
        {
            total = total + c.Duracion;
        }

        return total;
    }

    public void ListarUsuarios(Curso c)
    {
        Console.WriteLine("Usuarios en: " + c.Titulo);

        foreach (Usuario u in c.usuarios)
        {
            Console.WriteLine(u.Nombre + " - " + u.Email);
        }
    }
}