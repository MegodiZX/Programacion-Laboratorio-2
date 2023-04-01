internal class Program
{
    private static void Main(string[] args)
    {
        //hacer piramide con el tamaño ingresado por el usuario
        int pisos;
        int cantidadEspacios;
        string estrellas = "*";
        string espaciosDerecha= "";
        Console.WriteLine("Ingrese tamaño de la piramide");

        pisos = int.Parse(Console.ReadLine());
        cantidadEspacios = pisos * 2;
        for (int i = 0; i < pisos; i++)
        {
            if (i > 0)
            {
                estrellas = estrellas + "**";
            }
            
            espaciosDerecha = CalcularEspacios(cantidadEspacios);
            cantidadEspacios = cantidadEspacios - 1;
            Console.WriteLine("{0}{1}", espaciosDerecha, estrellas);
        }


    }
    private static string CalcularEspacios(int cantidad)
    {
        string espacios= "";
        for (int i = 0; i < cantidad; i++)
        {
            espacios = espacios + " ";
        }
        return espacios;
    }
}