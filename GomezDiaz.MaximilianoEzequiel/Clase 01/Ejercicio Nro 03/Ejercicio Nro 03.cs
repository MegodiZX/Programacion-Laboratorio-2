internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());

        for (int i = numero; i > 1; i--)
        {
            EsPrimo(i);
        }


    }

    private static void EsPrimo(int numero)
    {
        int resto;
        int cantidadCeros = 0;
        for (int i = 0; i < numero; i++)
        {
            resto = numero % (numero - i);
            if (resto == 0)
            {
                cantidadCeros++;
            }
        }
        if (cantidadCeros == 2)
        {
            Console.WriteLine("{0} es primo", numero);
        }
    }
}