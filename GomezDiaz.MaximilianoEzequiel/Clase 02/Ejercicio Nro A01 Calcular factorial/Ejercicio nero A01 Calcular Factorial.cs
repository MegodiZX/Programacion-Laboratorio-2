internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Consigna
        El factorial de un número es una operación que consiste en multiplicar un número “n”
        por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial
        de 3 es el resultado de multiplicar 3 por 2 por 1.
        En una aplicación de consola, desarrollar un método estático que calcule el factorial de
        un número dado.
         */
        int numero = 0;
        int resultado ;
        Console.WriteLine("ingrese un numero para calcular su factorial");
        numero = int.Parse(Console.ReadLine());
        resultado = Program.SacarFactorial(numero);
        Console.WriteLine("{0}", resultado);

    }
    private static int SacarFactorial(int valor)
    {
        int resultado=valor;
        for(int i=valor; i>1; i--)
        {
            resultado = resultado * (i-1);
            Console.WriteLine("resultado {0}, {1}", resultado, i);
        }
        return resultado;
    }
}