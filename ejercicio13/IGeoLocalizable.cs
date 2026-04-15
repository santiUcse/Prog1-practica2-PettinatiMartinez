public interface IGeoLocalizable
{
    double Latitud { get; }
    double Longitud { get; }
    double DistanciaA(double lat, double lon);
}