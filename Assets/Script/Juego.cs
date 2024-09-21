using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Juego : MonoBehaviour
{
    private List<Estructura> estructuras;

    public Juego()
    {
        estructuras = new List<Estructura>();
    }

    // M�todo para agregar estructuras a la ciudad
    public void AgregarEstructura(Estructura estructura)
    {
        estructuras.Add(estructura);
        Console.WriteLine($"{estructura.Nombre} ha sido agregada a la ciudad.");
    }

    // M�todo para operar todas las estructuras
    public void OperarCiudad()
    {
        Console.WriteLine("Operando las estructuras de la ciudad:");
        foreach (var estructura in estructuras)
        {
            int ingresos = estructura.CalcularIngresos();
            Console.WriteLine($"{estructura.Nombre} ha generado {ingresos} recursos.");
        }
    }

    // M�todo para mejorar todas las estructuras
    public void MejorarCiudad()
    {
        foreach (var estructura in estructuras)
        {
            estructura.Mejorar();
        }
    }
}
