public class Encomienda
{
    public string Codigo;
    public string Remitente;
    public string Destinatario;
    public string Estado;

    public Encomienda(string codigo, string remitente, string destinatario)
    {
        Codigo = codigo;
        Remitente = remitente;
        Destinatario = destinatario;
        Estado = "ingresada";
    }
}