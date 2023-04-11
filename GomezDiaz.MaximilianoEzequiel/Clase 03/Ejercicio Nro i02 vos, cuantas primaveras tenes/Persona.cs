using System;
using System.Security.Cryptography.X509Certificates;

public class Persona
{
    private string nombre;
    private DateTime fechaNacimiento;
    private int DNI;
    public Persona()
    {
        this.nombre = "";
        this.fechaNacimiento = DateTime.Now;
        this.DNI = 0;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public void SetNombre(string nombreIngresado)
    {
        this.nombre = nombreIngresado;
    }

    public DateTime GetFecha()
    {
        return this.fechaNacimiento;
    }

    public void SetFecha(DateTime fechaIngresada)
    {
        this.fechaNacimiento = fechaIngresada;
    }

    public int GetDNI()
    {
        return this.DNI;
    }

    public void SetDNI(int DNIIngresado)
    {
        this.DNI = DNIIngresado;
    }

    public static string Mostrar(Persona x)
    {
        return "Nombre:" + x.nombre + "\nEdad:  " + CalcularEdad(x.fechaNacimiento) + "\nDNI:" + x.DNI + "\n";
    }

    public static int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaHoy = DateTime.Now;
        int Edad;
        Edad = (fechaHoy - fechaNacimiento).Days;
        Edad = Edad / 360;

        return Edad;
    }

    public static string CalcularLegalidad(Persona x)
    {
        string esMayorONo = "Es menor de edad";
        
        if(CalcularEdad(x.fechaNacimiento) > 18)
        {
            esMayorONo = "Es mayor de edad";
        }

        return esMayorONo;
    }

    public Persona(string nombre, DateTime fecha, int DNI)
    {
        SetNombre(nombre);
        SetFecha(fecha);
        SetDNI(DNI);
    }
}
