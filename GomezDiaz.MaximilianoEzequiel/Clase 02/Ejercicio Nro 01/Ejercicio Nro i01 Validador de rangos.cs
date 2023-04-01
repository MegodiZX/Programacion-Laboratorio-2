internal class Validador
{
    private static void Main(string[] args)
    {
        /*
        Realizar una clase llamada Validador que posea un método estático llamado Validar
        con la siguiente firma:
        bool Validar(int valor, int min, int max)
        ● valor: dato a validar.
        ● min: mínimo valor incluido.
        ● max: máximo valor incluido.
        Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
        anteriormente que estén dentro del rango -100 y 100.
        Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el
        promedio.
        IMPORTANTE
        Utilizar variables escalares, NO utilizar vectores/arrays.
        */
        int numero;
        int minIngresado = 0;
        int maxIngresado = 0;
        float promedio;
        int vueltas = 3;// pasar a 10
        int acumulador=0;

        Console.WriteLine("Ingrese 10 numeros (entre -100 y 100)");
        
        for (int i = 0; i< vueltas; i++)
        {
            numero = int.Parse(Console.ReadLine());
            while(!Validador.Validar(numero,-100,100))
            {
                Console.WriteLine("Error. Ingrese solo numeros entre -100 y 100");
                numero = int.Parse(Console.ReadLine());
            }
            if (i == 0)
            {
                maxIngresado = numero;
                minIngresado = numero;
            }
            else
            {
                if (numero > maxIngresado)
                {
                    maxIngresado = numero;
                }
                else
                {
                    if (numero < minIngresado)
                    {
                        minIngresado = numero;
                    }

                }
            }
            acumulador = acumulador + numero;
        }
        promedio = acumulador / (float)vueltas;

        Console.WriteLine("El minimo ingresado fue {0} el maximo ingresado fue {1} y el promedio es {2}", minIngresado, maxIngresado, promedio);

    }

    private static bool Validar(int valor, int minimo, int maximo)
    {
        bool todoOk = false;
        if(valor>minimo && valor<maximo)
        {
            todoOk = true;
        }
        return todoOk;
    }
}