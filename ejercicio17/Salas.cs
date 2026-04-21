public class Salas
{
    public int Numero {get;set;}
    public int Capacidad {get;set;}
    public int Fila{get;set;}
    public int NumButaca{get;set;}


    public Sala(int numero, int capacidad, int fila, int numButaca)
    {
        Numero = numero;
        Capacidad = capacidad;
        Fila = fila;
        NumButaca = numButaca;
    }

}