namespace GestionHospital;

public class Paciente
{
    public string Nombre { get; set; }
    public string HistoriaClinica { get; set; }
    public string GrupoSanguineo { get; set; }

    public Paciente(string nombre, string historia, string grupo)
    {
        Nombre = nombre;
        HistoriaClinica = historia;
        GrupoSanguineo = grupo;
    }
}