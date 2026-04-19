namespace SistemaFacturacion;

public class Cliente
{
    public string Nombre { get; set; }
    public string CUIT { get; set; }
    public string Direccion { get; set; }

    public Cliente(string nombre, string cuit, string direccion)
    {
        Nombre = nombre;
        CUIT = cuit;
        Direccion = direccion;
    }
}