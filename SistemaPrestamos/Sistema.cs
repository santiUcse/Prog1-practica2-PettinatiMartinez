namespace SistemaPrestamos;

public class Sistema
{
    public List<Cliente> Clientes { get; set; }

    public Sistema()
    {
        Clientes = new List<Cliente>();
    }

    public void AgregarCliente(Cliente c)
    {
        Clientes.Add(c);
    }
}