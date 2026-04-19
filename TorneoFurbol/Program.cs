using TorneoFurbol;

class Program
{
    static void Main()
    {
        Torneo torneo = new Torneo("Liga");

        while (true)
        {
            Console.WriteLine("\n--- LaRedo ---");
            Console.WriteLine("1 - Crear equipo");
            Console.WriteLine("2 - Crear jugador");
            Console.WriteLine("3 - Crear partido");
            Console.WriteLine("4 - Jugar partido");
            Console.WriteLine("5 - Tabla");
            Console.WriteLine("6 - Goleador");
            Console.WriteLine("7 - Amarillas");
            Console.WriteLine("8 - Clasificados");
            Console.WriteLine("9 - Salir");

            string op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                Console.WriteLine("Nombre equipo:");
                string n = Console.ReadLine() ?? "";

                Console.WriteLine("DT:");
                string dt = Console.ReadLine() ?? "";

                torneo.AgregarEquipo(new Equipo(n, dt));
            }

            else if (op == "2")
            {
                Console.WriteLine("Equipo:");
                string eq = Console.ReadLine() ?? ""; //pedi el nombre del equipo tipo "fantoche"
                //eq se hace fantoche digamo
                Equipo e = torneo.Equipos.Find(x => x.Nombre == eq); //aca busca con el .Find un coso que se llame fantoche

                if (e != null)
                {
                    Console.WriteLine("Nombre jugador:");
                    string n = Console.ReadLine() ?? "";

                    Console.WriteLine("DNI:");
                    string d = Console.ReadLine() ?? "";

                    Console.WriteLine("Posicion:");
                    string p = Console.ReadLine() ?? "";

                    e.Jugadores.Add(new Jugador(n, d, p));
                }
            }

            else if (op == "3")
            {
                Console.WriteLine("Local:");
                string l = Console.ReadLine() ?? "";

                Console.WriteLine("Visitante:");
                string v = Console.ReadLine() ?? "";

                Console.WriteLine("Fecha:");
                string f = Console.ReadLine() ?? "";

                Equipo el = torneo.Equipos.Find(x => x.Nombre == l);
                Equipo ev = torneo.Equipos.Find(x => x.Nombre == v);

                torneo.AgregarPartido(new Partido(el, ev, f));
            }

            else if (op == "4")
            {
                Console.WriteLine("Indice partido:");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Goles local:");
                int gl = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Goles visitante:");
                int gv = Convert.ToInt32(Console.ReadLine());

                torneo.Partidos[i].Jugar(gl, gv);
            }

            else if (op == "5")
            {
                torneo.Tabla();
            }

            else if (op == "6")
            {
                torneo.Goleador();
            }

            else if (op == "7")
            {
                torneo.Amarillas();
            }

            else if (op == "8")
            {
                torneo.Clasificados();
            }

            else if (op == "9")
            {
                break;
            }
        }
    }
}