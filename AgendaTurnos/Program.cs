using AgendaTurnos;
class Program
{
    static void Main()
    {
        Peluqeria peluqeria = new Peluqeria();

        Peluquero p1 = new Peluquero("Juan");
        Peluquero p2 = new Peluquero("Ana");

        peluqeria.AgregarPeluquero(p1);
        peluqeria.AgregarPeluquero(p2);

        while (true)
        {
            Console.WriteLine("\n--- MENU PELUQUERIA ---");
            Console.WriteLine("1 - Agendar turno");
            Console.WriteLine("2 - Cancelar turno");
            Console.WriteLine("3 - Listar turnos por fecha");
            Console.WriteLine("4 - Ver disponibilidad");
            Console.WriteLine("5 - Salir");

            string opcion = Console.ReadLine() ?? "";

            if (opcion == "1")
            {
                Peluquero elegido = ElegirPeluquero(p1, p2);

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine() ?? "";

                Console.WriteLine("Hora:");
                string hora = Console.ReadLine() ?? "";

                Console.WriteLine("Cliente:");
                string cliente = Console.ReadLine() ?? "";

                Console.WriteLine("Servicio:");
                string servicio = Console.ReadLine() ?? "";

                if (elegido.EstaDisponible(fecha, hora))
                {
                    Turno t = new Turno(fecha, hora, cliente, servicio);
                    elegido.AsignarTurno(t);
                    Console.WriteLine("Turno asignado");
                }
                else
                {
                    Console.WriteLine("Horario ocupado");
                }
            }

            else if (opcion == "2")
            {
                Peluquero elegido = ElegirPeluquero(p1, p2);

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine() ?? "";

                Console.WriteLine("Hora:");
                string hora = Console.ReadLine() ?? "";

                elegido.CancelarTurno(fecha, hora);
            }

            else if (opcion == "3")
            {
                Peluquero elegido = ElegirPeluquero(p1, p2);

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine() ?? "";

                elegido.ListarTurnosPorFecha(fecha);
            }

            else if (opcion == "4")
            {
                Peluquero elegido = ElegirPeluquero(p1, p2);

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine() ?? "";

                Console.WriteLine("Hora:");
                string hora = Console.ReadLine() ?? "";

                bool libre = elegido.EstaDisponible(fecha, hora);

                Console.WriteLine(libre ? "Disponible" : "Ocupado");
            }

            else if (opcion == "5")
            {
                break;
            }
        }
    }

    static Peluquero ElegirPeluquero(Peluquero p1, Peluquero p2)
    {
        Console.WriteLine("Elegir peluquero:");
        Console.WriteLine("1 - Juan");
        Console.WriteLine("2 - Ana");

        string op = Console.ReadLine() ?? "";

        if (op == "2")
            return p2;

        return p1;
    }
}