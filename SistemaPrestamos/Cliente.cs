using System;

namespace SistemaPrestamos;

public class Cliente
{
    public string Nombre { get; set; }
    public string CUIT { get; set; }
    public List<Prestamo> Prestamos { get; set; }

    public Cliente(string nombre, string cuit)
    {
        Nombre = nombre;
        CUIT = cuit;
        Prestamos = new List<Prestamo>();
    }

    public int PrestamosActivos()
    {
        int count = 0;

        foreach (Prestamo p in Prestamos)
        {
            if (p.Activo)
                count++;
        }

        return count;
    }

    public double DeudaTotal()
    {
        double total = 0;

        foreach (Prestamo p in Prestamos)
        {
            if (p.Activo)
                total += p.Monto;
        }

        return total;
    }

    public bool PuedeSolicitar()
    {
        return PrestamosActivos() < 2;
    }
}