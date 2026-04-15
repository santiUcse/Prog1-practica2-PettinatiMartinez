Estacionamiento est = new Estacionamiento();

est.Ingresar(new Vehiculo("ABC123", "Juan"));
est.Ingresar(new Vehiculo("DEF456", "maria"));
est.Ingresar(new Vehiculo("GHI789", "Carlos"));

Console.WriteLine("Lugares libre: " + est.LugaresLibres());

Vehiculo v = est.Buscar("DEF456");

if (v != null)
{
    Console.WriteLine(v.Patente + " " + v.Dueño);
}

est.Egresar("DEF456");

Console.WriteLine("Despues:");
Console.WriteLine("lugares libress: " + est.LugaresLibres());