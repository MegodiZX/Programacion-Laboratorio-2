internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        while (numero < 0)
        {
            Console.WriteLine("{0}", numero);
            Console.WriteLine("ERROR. ¡Reingresar número!");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El cuadrado de {0} es: {1} y el cubo es {2}", numero, Math.Pow(numero, 2), Math.Pow(numero, 3));
    }
}