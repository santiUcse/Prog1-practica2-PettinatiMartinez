public class Estacionamiento
{
    public List<Vehiculo> vehiculos = new List<Vehiculo>();
    public int capacidad = 3;

    public bool Ingresar(Vehiculo v)
    {
        if (vehiculos.Count >= capacidad)
        {
            return false;
        }

        vehiculos.Add(v);
        return true;
    }

    public void Egresar(string patente)
    {
        for (int i = 0; i < vehiculos.Count; i++)
        {
            if (vehiculos[i].Patente == patente)
            {
                vehiculos.RemoveAt(i);
                return;
            }
        }
    }

    public Vehiculo Buscar(string patente)
    {
        for (int i = 0; i < vehiculos.Count; i++)
        {
            if (vehiculos[i].Patente == patente)
            {
                return vehiculos[i];
            }
        }

        return null;
    }

    public int LugaresLibres()
    {
        return capacidad - vehiculos.Count;
    }
}