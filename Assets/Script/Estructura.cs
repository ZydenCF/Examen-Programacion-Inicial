using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Estructura : MonoBehaviour
{
    public string Nombre;
    public int Nivel;

    public void Inicializar(string nombre, int nivel)
    {
        Nombre = nombre;
        Nivel = nivel;
    }

    public abstract int CalcularIngresos();

    public virtual void Mejorar()
    {
        Nivel++;
        Debug.Log($"{Nombre} ha sido mejorado al nivel {Nivel}.");
    }

    public abstract void Operar();
}