using Ejercicio2;
using System;
using System.Collections.Generic;

class Program() {
    static void Main()
    {
        List<Bebida> bebidas = new List<Bebida>();

        try
        {
            
            bebidas.Add(new Cafe("Latte", 150, true));
            bebidas.Add(new Jugo("DeNaranja", 150, "naranja"));
            
         
            bebidas.Add(new Agua("Aguita", 150, false));

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error al crear bebida: " + ex.Message);
        }

        Console.WriteLine("Lista de bebidas: ");

        foreach (Bebida v in bebidas)
        {
            Console.WriteLine(v.Preparar());
            Console.WriteLine(v.MostrarPrecio());
        }
    }
}