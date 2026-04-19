namespace SistemaPrestamos;

public class Prestamo
{
    public double Monto { get; set; }
    public double Tasa { get; set; }
    public int Cuotas { get; set; }
    public bool Activo { get; set; }

    public Prestamo(double monto, double tasa, int cuotas)
    {
        Monto = monto;
        Tasa = tasa;
        Cuotas = cuotas;
        Activo = true;
    }

    public double ValorCuota()
    {
        return (Monto * (1 + Tasa)) / Cuotas;
    }

    public void Cancelar()
    {
        Activo = false;
    }
}