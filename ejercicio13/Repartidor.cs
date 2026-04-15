using System;

public class Repartidor : IGeoLocalizable
{
    public string Nombre;
    public double Latitud { get; set; }
    public double Longitud { get; set; }

    public Repartidor(string nombre, double lat, double lon)
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
}

