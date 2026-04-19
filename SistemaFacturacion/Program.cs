using SistemaFacturacion;

class Program
{
    static void Main()
    {
        Sistema sistema = new Sistema();
        Factura factura = null;
        int numero = 1;

        while (true)
        {
            Console.WriteLine("\n--- MENU FACTURACION ---");
            Console.WriteLine("1 - Crear factura");
            Console.WriteLine("2 - Agregar linea");
            Console.WriteLine("3 - Quitar linea");
            Console.WriteLine("4 - Ver total");
            Console.WriteLine("5 - Emitir factura");
            Console.WriteLine("6 - Anular factura");
            Console.WriteLine("7 - Salir");

            string op = Console.ReadLine() ?? "";

            if (op == "1")
            {
                Console.WriteLine("Cliente nombre:");
                string nombre = Console.ReadLine() ?? "";

                Console.WriteLine("CUIT:");
                string cuit = Console.ReadLine() ?? "";

                Console.WriteLine("Direccion:");
                string dir = Console.ReadLine() ?? "";

                Cliente c = new Cliente(nombre, cuit, dir);

                factura = new Factura(numero++, c);
                sistema.AgregarFactura(factura);

                Console.WriteLine("Factura creada");
            }

            else if (op == "2")
            {
                if (factura == null) continue;

                Console.WriteLine("Producto:");
                string nombre = Console.ReadLine() ?? "";

                Console.WriteLine("Precio:");
                double precio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("IVA (ej 0.21):");
                double iva = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Cantidad:");
                int cant = Convert.ToInt32(Console.ReadLine());

                Producto p = new Producto(nombre, precio, iva);
                LineaFactura l = new LineaFactura(p, cant);

                factura.AgregarLinea(l);
            }

            else if (op == "3")
            {
                if (factura == null) continue;

                factura.QuitarLinea();
            }

            else if (op == "4")
            {
                if (factura == null) continue;

                Console.WriteLine("Subtotal: " + factura.Subtotal());
                Console.WriteLine("IVA: " + factura.IVA());
                Console.WriteLine("Total: " + factura.Total());
            }

            else if (op == "5")
            {
                if (factura == null) continue;

                factura.Emitir();
                Console.WriteLine("Factura emitida");
            }

            else if (op == "6")
            {
                if (factura == null) continue;

                factura.Anular();
                Console.WriteLine("Factura anulada");
            }

            else if (op == "7")
            {
                break;
            }
        }
    }
}