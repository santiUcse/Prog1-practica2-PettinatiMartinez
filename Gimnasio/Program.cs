class Program
{
    static void Main()
    {
        Gimnasio gym = new Gimnasio();

        Console.WriteLine("Ingrese nombre del socio:");
        string nombre = Console.ReadLine() ?? "";

        Console.WriteLine("Ingrese edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        Socio socio = new Socio(nombre, edad);
        gym.AgregarSocio(socio);

        Console.WriteLine("Ingrese nombre de la actividad:");
        string act = Console.ReadLine() ?? "";

        Console.WriteLine("Ingrese cupo:");
        int cupo = Convert.ToInt32(Console.ReadLine());

        Actividad actividad = new Actividad(act, cupo);
        gym.AgregarActividad(actividad);

        if (actividad.AgregarSocio(socio))
        {
            Console.WriteLine("Inscripto correctamente");
        }
        else
        {
            Console.WriteLine("No se pudo inscribir");
        }

        Console.WriteLine("Total inscriptos: " + actividad.Inscriptos.Count);
    }
}