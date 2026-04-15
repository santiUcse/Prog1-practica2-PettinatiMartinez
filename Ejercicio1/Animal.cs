namespace Ejercicio1;

public class Animal
{
    public string Nombre;
    public string Especie;
    public int Edad;
    public bool Activo;

    public Animal(string nombre, string especie, int edad)
    {
        Nombre = nombre;
        Especie = especie;
        Edad = edad;
        Activo = true;
    }
}