using System.Runtime.CompilerServices;

internal class Calculadora
{
    private static void Main(string[] args)
    {
        /*
         Realizar un programa que permita realizar operaciones matemáticas simples (suma,
        resta, multiplicación y división).
        Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando
        y la operación matemática. El método devolverá el resultado de la operación.
        Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe
        utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true
        si el operando es distinto de cero.
        Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar
        (ingresando el caracter +, -, * o /).
        El usuario decidirá cuándo finalizar el programa.
         */
        float numero;
        float numero2; 
        float resultado;
        char operando;
        char respuesta = 'y';
        do
        {
            Console.WriteLine("Ingrese primer numero");
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese operador de la operacion que desea realizar ( + - * / )");
            operando = char.Parse(Console.ReadLine());

            while(operando!='+'&& operando != '-'&& operando != '*' && operando != '/')
            {
                Console.WriteLine("Error ingrese solo ( + - * / )");
                operando = char.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("{0}",resultado = Calcular(numero,numero2,operando));
            Console.WriteLine("Desea continuar? (y/n)");
            respuesta = char.Parse(Console.ReadLine());

        } while(respuesta != 'n');
    }
    public static float Calcular(float Operando1, float Operando2, char Operando)
    {
        float resultado=0;
        switch(Operando)
        {
            case '+':
                {
                    Console.WriteLine("suma");
                    resultado = Operando1 + Operando2;
                }break;
            case '-':
                {
                    Console.WriteLine("resta");
                    resultado = Operando1 - Operando2;
                }break;
            case '*':
                {
                    Console.WriteLine("multiplicacion");
                    resultado = Operando1 * Operando2;
                }break;
            case '/':
                {
                    if(Validar(Operando2))
                    {
                        Console.WriteLine("division");
                        resultado = Operando1 / Operando2;
                    }else
                    {
                        Console.WriteLine("no se puede dividir por 0");
                    }
                    
                }break;
        }
        return resultado;
    }
    
    private static bool Validar(float numero)
    {
        bool todoOk = false;

        if(numero!=0)
        {
            todoOk = true;
        }
        return todoOk;
    }
}