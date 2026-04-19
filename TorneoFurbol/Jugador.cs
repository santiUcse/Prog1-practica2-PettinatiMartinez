namespace TorneoFurbol;
public class Jugador
{
    public string Nombre { get; set; }
    public string DNI { get; set; }
    public string Posicion { get; set; }
    public int Goles { get; set; }
    public int Amarillas { get; set; }

    public Jugador(string nombre, string dni, string posicion)
    {
        Nombre = nombre;
        DNI = dni;
        Posicion = posicion;
        Goles = 0;
        Amarillas = 0;
    }
}