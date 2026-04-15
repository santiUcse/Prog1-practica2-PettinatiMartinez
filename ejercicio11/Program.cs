Concesionaria c = new Concesionaria();

c.Agregar(new Auto("Toyota", "Corolla", 2020, 20000, 4, "nafta"));
c.Agregar(new Camioneta("Ford", "ranger", 2021, 30000, 1000, "4x4"));
c.Agregar(new VehiculoElectrico("Tesla", "Model 3", 2022, 40000, 500, 8));

Console.WriteLine("todos:");
c.Listar();

Console.WriteLine("autos :");
c.FiltrarAutos();

Console.WriteLine("prom:");
Console.WriteLine(c.Promedio());