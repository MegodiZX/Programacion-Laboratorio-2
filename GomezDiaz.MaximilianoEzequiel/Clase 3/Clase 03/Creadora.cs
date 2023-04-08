using System;
using System.Runtime.CompilerServices;

public class Creadora
{
	private DateTime fechaCreacionPrimerObjeto;
	private int contadorObjetosCreados;
	private DateTime fechaCreacion;

    public int ObtenerCantidadObjetosCreados()
	{
		return this.contadorObjetosCreados;
	}

	public Constructor()
	{
        this.fechaCreacionPrimerObjeto = DateTime.Now;
		this.contadorObjetosCreados=0;
    }

	public Creadora ConstructorInstancia()
	{
		this.fechaCreacion = DateTime.Now;
		return this.fechaCreacion;
	}
	


}
