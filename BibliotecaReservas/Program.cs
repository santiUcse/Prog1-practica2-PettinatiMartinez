using BibliotecaReservas;

class Program
{
    static void Main()
    {
        Biblioteca bib = new Biblioteca();

        Usuario u = null;

        while (true)
        {
            Console.WriteLine("\n--- BIBLIOTECA ---");
            Console.WriteLine("1 - Crear usuario");
            Console.WriteLine("2 - Agregar libro");
            Console.WriteLine("3 - Prestar libro");
            Console.WriteLine("4 - Devolver libro");
            Console.WriteLine("5 - Reservar libro");
            Console.WriteLine("6 - Ranking");
            Console.WriteLine("7 - Salir");

            string op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                Console.WriteLine("Nombre:");
                string n = Console.ReadLine() ?? "";

                Console.WriteLine("DNI:");
                string d = Console.ReadLine() ?? "";

                u = new Usuario(n, d);
            }

            else if (op == "2")
            {
                Console.WriteLine("Titulo:");
                string t = Console.ReadLine() ?? "";

                Console.WriteLine("Autor:");
                string a = Console.ReadLine() ?? "";

                Console.WriteLine("ISBN:");
                string i = Console.ReadLine() ?? "";

                Console.WriteLine("Ejemplares:");
                int e = Convert.ToInt32(Console.ReadLine());

                bib.AgregarLibro(new Libro(t, a, i, e));
            }

            else if (op == "3")
            {
                if (u == null) continue;

                Console.WriteLine("ISBN:");
                string i = Console.ReadLine() ?? "";

                bib.Prestar(i, u);
            }

            else if (op == "4")
            {
                if (u == null) continue;

                Console.WriteLine("ISBN:");
                string i = Console.ReadLine() ?? "";

                bib.Devolver(i, u);
            }

            else if (op == "5")
            {
                if (u == null) continue;

                Console.WriteLine("ISBN:");
                string i = Console.ReadLine() ?? "";

                bib.Reservar(i, u);
            }

            else if (op == "6")
            {
                bib.Ranking();
            }

            else if (op == "7")
            {
                break;
            }
        }
    }
}