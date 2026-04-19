namespace SistemaJerarquia;
public class RRHH
{
    public List<EmpleadoPlanta> Plantas = new List<EmpleadoPlanta>();
    public List<EmpleadoContrato> Contratos = new List<EmpleadoContrato>();
    public List<Gerente> Gerentes = new List<Gerente>();

    public double TotalNomina()
    {
        double total = 0;

        foreach (var e in Plantas)
            total += e.Sueldo();

        foreach (var e in Contratos)
            total += e.Sueldo();

        foreach (var e in Gerentes)
            total += e.Sueldo();

        return total;
    }
}