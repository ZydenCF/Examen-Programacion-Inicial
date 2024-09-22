using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Construccion : IConstruccion
{
    protected string nombre;
    protected int nivel;
    protected int costoMantenimiento;

    public Construccion(string nombre, int nivel, int costoMantenimiento)
    {
        this.nombre = nombre;
        this.nivel = nivel;
        this.costoMantenimiento = costoMantenimiento;
    }

    public abstract void Operar();

    public int ObtenerCostoMantenimiento()
    {
        return costoMantenimiento;
    }
}
