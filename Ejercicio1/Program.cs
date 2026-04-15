using Ejercicio1;
Veterinaria vet = new Veterinaria();

vet.RegistrarAnimal(new Animal("luna", "Perro", 5));
vet.RegistrarAnimal(new Animal("Michi", "Gato", 3));
vet.RegistrarAnimal(new Animal("pepe", "Ave", 2));

Console.WriteLine("lista:");
vet.Listar();

Console.WriteLine("Buscar Michi:");
Animal a = vet.Buscar("Michi");

if (a != null)
{
    Console.WriteLine(a.Nombre + " " + a.Especie + " " + a.Edad + " años");
}

Console.WriteLine("dar de baja michi:");
vet.DarDeBaja("Michi");

Console.WriteLine("LISTA FINAL:");
vet.Listar();