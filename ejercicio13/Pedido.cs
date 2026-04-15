using System.Collections.Generic;

public class Pedido
{
    public Cliente Cliente;
    public Restaurante Restaurante;
    public Repartidor Repartidor;
    public string Estado;

    public List<Item> items = new List<Item>();

    public Pedido(Cliente c, Restaurante r)
    {
        Cliente = c;
        Restaurante = r;
        Estado = "pendiente";
    }

    public double Total()
    {
        double total = 0;

        foreach (Item i in items)
        {
            total += i.Precio;
        }

        return total + 500;
    }
}