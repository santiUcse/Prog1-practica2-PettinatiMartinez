namespace Ejercicio1;


public class Veterinaria
{
    public List<Animal> animales = new List<Animal>();

   
    public void RegistrarAnimal(Animal a)
    {
        animales.Add(a);
    }

    
    public void DarDeBaja(string nombre)
    {
        foreach (Animal a in animales)
        {
            if (a.Nombre == nombre && a.Activo == true)
            {
                a.Activo = false;
            }
        }
    }

    
    public Animal Buscar(string nombre)
    {
        foreach (Animal a in animales)
        {
            if (a.Nombre == nombre && a.Activo == true)
            {
                return a;
            }
        }
        return null;
    }

  
public void Listar()
{
    for (int i = 0; i < animales.Count - 1; i++)
    {
        for (int j = i + 1; j < animales.Count; j++)
        {
            if (animales[i].Nombre.CompareTo(animales[j].Nombre) > 0)
            {
                Animal aux = animales[i];
                animales[i] = animales[j];
                animales[j] = aux;
            }
        }
    }

 
    foreach (Animal a in animales)
    {
        if (a.Activo == true)
        {
            Console.WriteLine(a.Nombre + " - " + a.Especie + " - " + a.Edad + " años");
        }
    }
}
}