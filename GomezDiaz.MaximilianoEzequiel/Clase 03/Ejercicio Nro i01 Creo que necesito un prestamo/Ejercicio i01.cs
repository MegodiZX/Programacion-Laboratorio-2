internal class Program
{
    private static void Main(string[] args)
    {
       
        Cuenta cuentaDePrueba = new Cuenta("razonSocial?", 0);
        Console.WriteLine(Cuenta.Mostrar(cuentaDePrueba));
        Cuenta.Ingresar(2000, cuentaDePrueba);
        Console.WriteLine(Cuenta.Mostrar(cuentaDePrueba));
        Cuenta.Retirar(1000, cuentaDePrueba);
        Console.WriteLine(Cuenta.Mostrar(cuentaDePrueba));


    }       
}
