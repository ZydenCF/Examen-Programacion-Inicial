using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion : Construccion
{
    private int recursosGenerados;

    public Recoleccion(string nombre, int nivel, int costoMantenimiento, int recursosGenerados): base(nombre, nivel, costoMantenimiento)
    {
        this.recursosGenerados = recursosGenerados;
    }

    public override void Operar()
    {
        recursosGenerados *= nivel;
    }

    public int ObtenerRecursosGenerados()
    {
        return recursosGenerados;
    }
}
