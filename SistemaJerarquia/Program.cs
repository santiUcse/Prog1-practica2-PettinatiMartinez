using SistemaJerarquia;
class Program
{
    static void Main()
    {
        RRHH rrhh = new RRHH();

        while (true)
        {
            Console.WriteLine("\n1 Planta");
            Console.WriteLine("2 Contrato");
            Console.WriteLine("3 Gerente");
            Console.WriteLine("4 Total nomina");
            Console.WriteLine("5 Salir");

            string op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine() ?? "";

                Console.WriteLine("Legajo:");
                string legajo = Console.ReadLine() ?? "";

                Console.WriteLine("Fecha (DD-MM-AAAA):");
                string fecha = Console.ReadLine() ?? "";

                Console.WriteLine("Sueldo base:");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                rrhh.Plantas.Add(new EmpleadoPlanta(nombre, legajo, fecha, sueldo));
            }

            else if (op == "2")
            {
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine() ?? "";

                Console.WriteLine("Legajo:");
                string legajo = Console.ReadLine() ?? "";

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine() ?? "";

                Console.WriteLine("Valor hora:");
                double vh = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Horas:");
                int horas = Convert.ToInt32(Console.ReadLine());

                rrhh.Contratos.Add(new EmpleadoContrato(nombre, legajo, fecha, vh, horas));
            }

            else if (op == "3")
            {
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine() ?? "";

                Console.WriteLine("Legajo:");
                string legajo = Console.ReadLine() ?? "";

                Console.WriteLine("Fecha:");
                string fecha = Console.ReadLine() ?? "";

                Console.WriteLine("Sueldo base:");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresos area:");
                double ing = Convert.ToDouble(Console.ReadLine());

                rrhh.Gerentes.Add(new Gerente(nombre, legajo, fecha, sueldo, ing));
            }

            else if (op == "4")
            {
                Console.WriteLine("Total nomina: " + rrhh.TotalNomina());
            }

            else if (op == "5")
            {
                break;
            }
        }
    }
}