using System;
using System.Collections.Generic;
using Ejercicio1;

class Program
{
    static void Main()
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        try
        {
            
            vehiculos.Add(new Auto("Toyota", "Corolla", 2020, 4));
            vehiculos.Add(new Auto("Ford", "Fiesta", 2018, 5));

         
            vehiculos.Add(new Moto("Honda", "CBR", 2022, false));
            vehiculos.Add(new Moto("Yamaha", "YZF", 2019, true));

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error al crear vehículo: " + ex.Message);
        }

        Console.WriteLine("Lista de vehículos: ");

        foreach (Vehiculo v in vehiculos)
        {
            Console.WriteLine(v.Describir());
        }
    }
}