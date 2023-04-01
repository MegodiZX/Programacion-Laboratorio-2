internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int maximo = 0;
        int minimo = 0;
        int acumulador = 0;
        float promedio = 0f;
        int i;
        Console.WriteLine("Ingrese 5 numeros");

        for (i = 0; i < 5; i++)
        {
            numero = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                maximo = numero;
                minimo = numero;
            }
            else
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }

                }
            }
            acumulador = acumulador + numero;
        }
        promedio = acumulador / (float)5;

        Console.WriteLine("El Maximo es {0} el minimo es {1} y el promedio es {2}", maximo, minimo, promedio);
    }
}