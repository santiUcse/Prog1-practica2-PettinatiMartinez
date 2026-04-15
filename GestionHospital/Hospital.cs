namespace GestionHospital;

public class Hospital
{
    public int CamasMaximas { get; set; }
    public List<Internacion> Internaciones { get; set; }

    public Hospital(int camas)
    {
        CamasMaximas = camas;
        Internaciones = new List<Internacion>();
    }

    public bool HayCamas()
    {
        int activas = 0;

        foreach (Internacion i in Internaciones)
            if (i.Activa())
                activas++;

        return activas < CamasMaximas;
    }

    public void AgregarInternacion(Internacion i)
    {
        if (HayCamas())
            Internaciones.Add(i);
    }

    public void DarAlta(string historia)
    {
        foreach (Internacion i in Internaciones)
        {
            if (i.Paciente.HistoriaClinica == historia && i.Activa())
            {
                i.FechaAlta = DateTime.Now.ToString("yyyy-MM-dd");
                break;
            }
        }
    }

    public int DiasInternado(string historia)
    {
        foreach (Internacion i in Internaciones)
        {
            if (i.Paciente.HistoriaClinica == historia)
            {
                DateTime ingreso = Convert.ToDateTime(i.FechaIngreso);
                DateTime fin = i.FechaAlta == null
                    ? DateTime.Now
                    : Convert.ToDateTime(i.FechaAlta);

                return (fin - ingreso).Days;
            }
        }

        return 0;
    }

    public void ReportePorEspecialidad()
    {
        Dictionary<string, int> contador = new Dictionary<string, int>();

        foreach (Internacion i in Internaciones)
        {
            if (i.Activa())
            {
                string esp = i.Medico.Especialidad;

                if (!contador.ContainsKey(esp))
                    contador[esp] = 0;

                contador[esp]++;
            }
        }

        foreach (var c in contador)
        {
            Console.WriteLine(c.Key + ": " + c.Value);
        }
    }
}