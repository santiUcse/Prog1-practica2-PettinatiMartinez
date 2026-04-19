using SistemaPrestamos;

class Program
{
    static void Main()
    {
        Sistema sistema = new Sistema();
        Cliente cliente = null;

        while (true)
        {
            Console.WriteLine("\n--- MENU PRESTAMOS ---");
            Console.WriteLine("1 - Crear cliente");
            Console.WriteLine("2 - Crear prestamo");
            Console.WriteLine("3 - Cancelar prestamo");
            Console.WriteLine("4 - Ver deuda total");
            Console.WriteLine("5 - Ver cuotas");
            Console.WriteLine("6 - Ver clientes");
            Console.WriteLine("7 - Salir");

            string op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine() ?? "";

                Console.WriteLine("CUIT:");
                string cuit = Console.ReadLine() ?? "";

                cliente = new Cliente(nombre, cuit);
                sistema.AgregarCliente(cliente);

                Console.WriteLine("Cliente creado");
            }

            else if (op == "2")
            {
                if (cliente == null)
                {
                    Console.WriteLine("Primero crea un cliente");
                    continue;
                }

                if (!cliente.PuedeSolicitar())
                {
                    Console.WriteLine("No puede solicitar mas prestamos");
                    continue;
                }

                Console.WriteLine("Monto:");
                double monto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Tasa (ej 0.1):");
                double tasa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Cuotas:");
                int cuotas = Convert.ToInt32(Console.ReadLine());

                Prestamo p = new Prestamo(monto, tasa, cuotas);
                cliente.Prestamos.Add(p);

                Console.WriteLine("Prestamo creado");
            }

            else if (op == "3")
            {
                if (cliente == null)
                {
                    Console.WriteLine("No hay cliente");
                    continue;
                }

                if (cliente.Prestamos.Count == 0)
                {
                    Console.WriteLine("No tiene prestamos");
                    continue;
                }

                cliente.Prestamos[0].Cancelar();
                Console.WriteLine("Prestamo cancelado");
            }

            else if (op == "4")
            {
                if (cliente == null)
                {
                    Console.WriteLine("No hay cliente");
                    continue;
                }

                Console.WriteLine("Deuda total: " + cliente.DeudaTotal());
            }

            else if (op == "5")
            {
                if (cliente == null)
                {
                    Console.WriteLine("No hay cliente");
                    continue;
                }

                foreach (Prestamo p in cliente.Prestamos)
                {
                    Console.WriteLine("Cuota: " + p.ValorCuota());
                }
            }

            else if (op == "6")
            {
                foreach (Cliente c in sistema.Clientes)
                {
                    Console.WriteLine(c.Nombre + " - " + c.CUIT);
                }
            }

            else if (op == "7")
            {
                break;
            }
        }
    }
}