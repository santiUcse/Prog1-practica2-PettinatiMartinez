using System;
using System.Collections.Generic;

public class Concesionaria
{
    public List<Vehiculo> vehiculos = new List<Vehiculo>();

    public void Agregar(Vehiculo v)
    {
        vehiculos.Add(v);
    }

    public void Listar()
    {
        foreach (Vehiculo v in vehiculos)
        {
            Console.WriteLine(v.Describir());
        }
    }

    public void FiltrarAutos()
    {
        foreach (Vehiculo v in vehiculos)
        {
            if (v is Auto)
            {
                Console.WriteLine(v.Describir());
            }
        }
    }

    public void FiltrarCamionetas()
    {
        foreach (Vehiculo v in vehiculos)
        {
            if (v is Camioneta)
            {
                Console.WriteLine(v.Describir());
            }
        }
    }

    public void FiltrarElectricos()
    {
        foreach (Vehiculo v in vehiculos)
        {
            if (v is VehiculoElectrico)
            {
                Console.WriteLine(v.Describir());
            }
        }
    }

    public double Promedio()
    {
        double total = 0;

        foreach (Vehiculo v in vehiculos)
        {
            total = total + v.Precio;
        }

        return total / vehiculos.Count;
    }
}