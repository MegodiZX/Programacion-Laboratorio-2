using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Cuenta
{
    private string titular;
    private int cantidad;

    public Cuenta()
    {
        this.titular = "";
        this.cantidad = 0;
    }

    public string Titular
    {
        get { return titular; }
    }

    public int Cantidad
    {
        get { return cantidad; }
        //aca iria un setter
    }

    public Cuenta(string titular, int cantidad)
    {
        this.titular = titular;
        this.cantidad = cantidad;

    }

    public static string Mostrar(Cuenta x)
    {
        return "Titular:"  + x.Titular +" Cantidad:  "+ x.Cantidad;
    }

    public void SetMonto(int montoIngresado)
    {
         cantidad = montoIngresado;
    }

    public static void Ingresar(int monto, Cuenta x)
    {
        if(monto>0)
        {
            x.SetMonto(monto);
        }
    }

    public static void Retirar(int monto, Cuenta x)
    {
        int total = x.Cantidad;
        x.SetMonto(total - monto);
    }


}