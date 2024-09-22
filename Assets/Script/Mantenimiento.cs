using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mantenimiento : Construccion
{
    private int capacidadMantenimiento;

    public Mantenimiento(string nombre, int nivel, int costoMantenimiento, int capacidadMantenimiento)
        : base(nombre, nivel, costoMantenimiento)
    {
        this.capacidadMantenimiento = capacidadMantenimiento;
    }

    public override void Operar()
    {
        capacidadMantenimiento *= nivel;
    }

    public int ObtenerCapacidadMantenimiento()
    {
        return capacidadMantenimiento;
    }
}
