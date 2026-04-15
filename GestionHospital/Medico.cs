namespace GestionHospital;

public class Medico
{
    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public string Especialidad { get; set; }

    public Medico(string nombre, string matricula, string especialidad)
    {
        Nombre = nombre;
        Matricula = matricula;
        Especialidad = especialidad;
    }
}