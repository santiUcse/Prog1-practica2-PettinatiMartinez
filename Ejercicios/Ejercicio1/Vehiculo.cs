using System.IO.Pipes;

namespace Ejercicio1;

public class Vehiculo
{
    public string Marca {get; set;}
    public string Modelo {get;set;}
    public int Anio {get;set;}

    public Vehiculo(string marca, string modelo, int anio)
    {
    
        if (anio < 1900) {
            throw new ArgumentException("El año no puede ser menor a 1900");
        }
        marca = Marca;
        modelo = Modelo;
        anio = Anio;

    }

    public virtual string Describir()
    {
        return $"{Marca} {Modelo} ({Anio})";
    }

}
