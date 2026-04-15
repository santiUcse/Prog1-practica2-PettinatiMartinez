SistemaEncomiendas s = new SistemaEncomiendas();

s.Registrar(new Encomienda("A1", "juan", "pedro"));
s.Registrar(new Encomienda("B2", "Maria", "Luis"));
s.Registrar(new Encomienda("C3", "Carlos", "Ana"));

Console.WriteLine("Estado A1: " + s.Consultar("A1"));

s.Avanzar("A1");
s.Avanzar("A1");

Console.WriteLine("Estado A1: " + s.Consultar("A1"));

Console.WriteLine("No entragadas:");
s.ListarNoEntregadas();