using System;
using System.Collections.Generic;

public class Usuario
{
    public string NombreUsuario;
    public string Biografia;

    public List<Usuario> seguidos = new List<Usuario>();
    public List<Publicacion> publicaciones = new List<Publicacion>();

    public Usuario(string nombre, string bio)
    {
        NombreUsuario = nombre;
        Biografia = bio;
    }

    public void Seguir(Usuario u)
    {
        if (!seguidos.Contains(u))
        {
            seguidos.Add(u);
        }
    }

    public void DejarDeSeguir(Usuario u)
    {
        seguidos.Remove(u);
    }

    public void Publicar(string texto, string fecha)
    {
        publicaciones.Add(new Publicacion(texto, fecha));
    }

    public void DarLike(Publicacion p)
    {
        p.Likes++;
    }

    public void VerFeed()
    {
        List<Publicacion> feed = new List<Publicacion>();

        foreach (Usuario u in seguidos)
        {
            foreach (Publicacion p in u.publicaciones)
            {
                feed.Add(p);
            }
        }

        for (int i = 0; i < feed.Count - 1; i++)
        {
            for (int j = i + 1; j < feed.Count; j++)
            {
                if (string.Compare(feed[i].Fecha, feed[j].Fecha) < 0)
                {
                    Publicacion aux = feed[i];
                    feed[i] = feed[j];
                    feed[j] = aux;
                }
            }
        }

        foreach (Publicacion p in feed)
        {
            Console.WriteLine(p.Fecha + " - " + p.Texto + " - " + p.Likes);
        }
    }
}