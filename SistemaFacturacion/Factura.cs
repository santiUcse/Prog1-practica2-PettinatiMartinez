namespace SistemaFacturacion;

public class Factura
{
    public int Numero { get; set; }
    public Cliente Cliente { get; set; }
    public List<LineaFactura> Lineas { get; set; }
    public string Estado { get; set; } // borrador, emitida, anulada

    public Factura(int numero, Cliente cliente)
    {
        Numero = numero;
        Cliente = cliente;
        Lineas = new List<LineaFactura>();
        Estado = "borrador";
    }

    public void AgregarLinea(LineaFactura l)
    {
        if (Estado == "borrador")
            Lineas.Add(l);
    }

    public void QuitarLinea()
    {
        if (Estado == "borrador" && Lineas.Count > 0)
            Lineas.RemoveAt(Lineas.Count - 1);
    }

    public double Subtotal()
    {
        double total = 0;

        foreach (LineaFactura l in Lineas)
            total += l.Subtotal();

        return total;
    }

    public double IVA()
    {
        double total = 0;

        foreach (LineaFactura l in Lineas)
            total += l.IVA();

        return total;
    }

    public double Total()
    {
        return Subtotal() + IVA();
    }

    public void Emitir()
    {
        if (Estado == "borrador")
            Estado = "emitida";
    }

    public void Anular()
    {
        Estado = "anulada";
    }
}