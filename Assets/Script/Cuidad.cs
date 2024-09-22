using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuidad : MonoBehaviour
{
    private List<IConstruccion> construcciones;
    private int recursosTotales;

    public Cuidad()
    {
        construcciones = new List<IConstruccion>();
        recursosTotales = 100; 
    }

    public void AgregarConstruccion(IConstruccion construccion)
    {
        construcciones.Add(construccion);
    }

    public int EjecutarTurno()
    {
        foreach (var construccion in construcciones)
        {
            construccion.Operar();
            recursosTotales -= construccion.ObtenerCostoMantenimiento();
        }
        return recursosTotales;
    }

    public List<IConstruccion> ObtenerConstrucciones()
    {
        return construcciones;
    }
}
