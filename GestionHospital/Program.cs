using GestionHospital;

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital(2);

        while (true)
        {
            Console.WriteLine("\n--- HOSPITAL ---");
            Console.WriteLine("1 - Nueva internacion");
            Console.WriteLine("2 - Dar alta");
            Console.WriteLine("3 - Dias internado");
            Console.WriteLine("4 - Reporte especialidades");
            Console.WriteLine("5 - Salir");

            string op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                Console.WriteLine("Paciente nombre:");
                string pn = Console.ReadLine() ?? "";

                Console.WriteLine("Historia clinica:");
                string hc = Console.ReadLine() ?? "";

                Console.WriteLine("Grupo sanguineo:");
                string gs = Console.ReadLine() ?? "";

                Paciente p = new Paciente(pn, hc, gs);

                Console.WriteLine("Medico nombre:");
                string mn = Console.ReadLine() ?? "";

                Console.WriteLine("Matricula:");
                string mat = Console.ReadLine() ?? "";

                Console.WriteLine("Especialidad:");
                string esp = Console.ReadLine() ?? "";

                Medico m = new Medico(mn, mat, esp);

                Console.WriteLine("Fecha ingreso (yyyy-MM-dd):");
                string fi = Console.ReadLine() ?? "";

                Console.WriteLine("Diagnostico:");
                string d = Console.ReadLine() ?? "";

                Internacion i = new Internacion(p, m, fi, d);

                if (hospital.HayCamas())
                {
                    hospital.AgregarInternacion(i);
                    Console.WriteLine("Internacion registrada");
                }
                else
                {
                    Console.WriteLine("No hay camas disponibles");
                }
            }

            else if (op == "2")
            {
                Console.WriteLine("Historia clinica:");
                string hc = Console.ReadLine() ?? "";

                hospital.DarAlta(hc);
            }

            else if (op == "3")
            {
                Console.WriteLine("Historia clinica:");
                string hc = Console.ReadLine() ?? "";

                Console.WriteLine("Dias internado: " + hospital.DiasInternado(hc));
            }

            else if (op == "4")
            {
                hospital.ReportePorEspecialidad();
            }

            else if (op == "5")
            {
                break;
            }
        }
    }
}