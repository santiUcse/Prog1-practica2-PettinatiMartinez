using System;

Cliente c1 = new Cliente("Juan");

Restaurante r1 = new Restaurante("Pizza", 10, 10);

Repartidor r1r = new Repartidor("Pedro", 11, 11);
Repartidor r2r = new Repartidor("Luis", 50, 50);

Plataforma p = new Plataforma();

p.AgregarRepartidor(r1r);
p.AgregarRepartidor(r2r);

Pedido pedido = p.CrearPedido(c1, r1);

pedido.items.Add(new Item("Pizza", 1000));
pedido.items.Add(new Item("Gaseosa", 500));

p.AsignarRepartidor(pedido);

Console.WriteLine(pedido.Repartidor.Nombre);

Console.WriteLine(pedido.Total());

p.Avanzar(pedido);
Console.WriteLine(pedido.Estado);
