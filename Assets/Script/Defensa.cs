using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensa : Construccion
{
    private int fuerzaDefensiva;

    public Defensa(string nombre, int nivel, int costoMantenimiento, int fuerzaDefensiva) : base(nombre, nivel, costoMantenimiento)
    {
        this.fuerzaDefensiva = fuerzaDefensiva;
    }

    public override void Operar()
    {
        fuerzaDefensiva *= nivel;
    }

    public int ObtenerFuerzaDefensiva()
    {
        return fuerzaDefensiva;
    }

}
