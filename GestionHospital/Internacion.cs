namespace GestionHospital;

public class Internacion
{
    public Paciente Paciente { get; set; }
    public Medico Medico { get; set; }
    public string FechaIngreso { get; set; }
    public string FechaAlta { get; set; } // puede ser null creo nose chagepete dijo que si
    public string Diagnostico { get; set; }

    public Internacion(Paciente p, Medico m, string ingreso, string diag)
    {
        Paciente = p;
        Medico = m;
        FechaIngreso = ingreso;
        Diagnostico = diag;
        FechaAlta = null;
    }

    public bool Activa()
    {
        return FechaAlta == null;
    }
}