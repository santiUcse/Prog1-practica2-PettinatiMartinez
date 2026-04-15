using System;
using System.Collections.Generic;

public class SistemaEncomiendas
{
    public List<Encomienda> lista = new List<Encomienda>();

    public void Registrar(Encomienda e)
    {
        lista.Add(e);
    }

    public void Avanzar(string codigo)
    {
        foreach (Encomienda e in lista)
        {
            if (e.Codigo == codigo)
            {
                if (e.Estado == "ingresada")
                {
                    e.Estado = "en camino";
                }
                else if (e.Estado == "en camino")
                {
                    e.Estado = "entregada";
                }
                return;
            }
        }
    }

    public string Consultar(string codigo)
    {
        foreach (Encomienda e in lista)
        {
            if (e.Codigo == codigo)
            {
                return e.Estado;
            }
        }

        return "no encontrada";
    }

    public void ListarNoEntregadas()
    {
        foreach (Encomienda e in lista)
        {
            if (e.Estado != "entregada")
            {
                Console.WriteLine(e.Codigo + " - " + e.Remitente + " - " + e.Destinatario + " - " + e.Estado);
            }
        }
    }
}