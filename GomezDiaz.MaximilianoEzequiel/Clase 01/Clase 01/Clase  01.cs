internal class Program
{
    private static void Main(string[] args)
    {
        int valor = 2;
        string otro_valor = "pip";
        //float valor_f = (float)9.9;  lo toma como tipo doble en lugar de float
        float valor_f = 9.9f;//solo se puede de esta manera porque es un literal, si es una variable se usa el casteo

        valor = (int)valor_f;

        if (valor == 9)
        {
            Console.WriteLine("entro en if");
        }
        else
        {
            Console.WriteLine("no entro en el if");
        }

        if (otro_valor == "pip")//en c# no es necesario usar el strcmp
        {
            Console.WriteLine("entro en if de comparacion entre strings");
        }

        //Console.ReadKey(); te permite esperar hasta que se ingrese algo por teclado
    }
}