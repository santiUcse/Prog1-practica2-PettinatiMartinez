using System;
using System.Collections.Generic;

public class Restaurante : IGeoLocalizable, ICalificable
{
    public string Nombre;
    public double Latitud { get; set; }
    public double Longitud { get; set; }

    public List<int> calificaciones = new List<int>();

    public Restaurante(string nombre, double lat, double lon)
    {
        Nombre = nombre;
        Latitud = lat;
        Longitud = lon;
    }

    public double DistanciaA(double lat, double lon)
    {
        double dx = Latitud - lat;
        double dy = Longitud - lon;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void AgregarCalificacion(int nota)
    {
        calificaciones.Add(nota);
    }

    public double Promedio()
    {
        double total = 0;

        foreach (int n in calificaciones)
        {
            total += n;
        }

        return calificaciones.Count == 0 ? 0 : total / calificaciones.Count;
    }
}
