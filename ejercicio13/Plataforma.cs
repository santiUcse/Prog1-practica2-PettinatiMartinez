using System;
using System.Collections.Generic;

public class Plataforma
{
    public List<Repartidor> repartidores = new List<Repartidor>();
    public List<Pedido> pedidos = new List<Pedido>();

    public void AgregarRepartidor(Repartidor r)
    {
        repartidores.Add(r);
    }

    public Pedido CrearPedido(Cliente c, Restaurante r)
    {
        Pedido p = new Pedido(c, r);
        pedidos.Add(p);
        return p;
    }

    public void AsignarRepartidor(Pedido p)
    {
        Repartidor mejor = null;
        double mejorDistancia = 999999;

        foreach (Repartidor r in repartidores)
        {
            double d = r.DistanciaA(p.Restaurante.Latitud, p.Restaurante.Longitud);

            if (d < mejorDistancia)
            {
                mejorDistancia = d;
                mejor = r;
            }
        }

        p.Repartidor = mejor;
    }

    public void Avanzar(Pedido p)
    {
        if (p.Estado == "pendiente")
            p.Estado = "en preparación";
        else if (p.Estado == "en preparación")
            p.Estado = "en camino";
        else if (p.Estado == "en camino")
            p.Estado = "entregado";
    }
}