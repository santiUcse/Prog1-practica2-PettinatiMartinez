namespace SistemaFacturacion;

public class Sistema
{
    public List<Factura> Facturas { get; set; }

    public Sistema()
    {
        Facturas = new List<Factura>();
    }

    public void AgregarFactura(Factura f)
    {
        Facturas.Add(f);
    }
}