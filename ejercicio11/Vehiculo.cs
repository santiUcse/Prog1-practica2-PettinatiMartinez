public class Vehiculo
{
    public string Marca;
    public string Modelo;
    public int Anio;
    public double Precio;

    public Vehiculo(string marca, string modelo, int anio, double precio)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        Precio = precio;
    }

    public virtual string Describir()
    {
        return Marca + " " + Modelo + " " + Anio + " - $" + Precio;
    }
}