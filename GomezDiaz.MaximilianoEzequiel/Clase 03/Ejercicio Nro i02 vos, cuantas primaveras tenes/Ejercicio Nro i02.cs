internal class Program
{
    private static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        Persona persona2 = new Persona("Juan", new DateTime (2013,02,12), 52432112);
        Persona persona3 = new Persona("Manfred", new DateTime(2004, 11, 03), 46657323);

        persona1.SetNombre("maxi");
        persona1.SetFecha(new DateTime (1999, 03, 27));
        persona1.SetDNI(41801932);
        Console.WriteLine(Persona.Mostrar(persona1));
        Console.WriteLine(Persona.CalcularLegalidad(persona1)+"\n");

        Console.WriteLine(Persona.Mostrar(persona2));
        Console.WriteLine(Persona.CalcularLegalidad(persona2) + "\n");

        Console.WriteLine(Persona.Mostrar(persona3));
        Console.WriteLine(Persona.CalcularLegalidad(persona3) + "\n");
    }
}