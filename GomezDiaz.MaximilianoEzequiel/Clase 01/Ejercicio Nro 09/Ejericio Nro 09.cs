internal class Program
{
    private static void Main(string[] args)
    {
        //hacer piramide con el tamaño ingresado por el usuario
        int pisos;
        string estrellas = "*";
        Console.WriteLine("Ingrese tamaño de la piramide");

        pisos = int.Parse(Console.ReadLine());

        for (int i = 0; i < pisos; i++)
        {
            if (i > 0)
            {
                estrellas = estrellas + "**";
            }
            Console.WriteLine("{0}", estrellas);
        }
    }
}