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

    public void AgregarEstructura(Estructura estructura)
    {
        estructuras.Add(estructura);
        Console.WriteLine($"{estructura.Nombre} ha sido agregada a la ciudad.");
    }

    public void OperarCiudad()
    {
        Console.WriteLine("Operando las estructuras de la ciudad:");
        foreach (var estructura in estructuras)
        {
            int ingresos = estructura.CalcularIngresos();
            Console.WriteLine($"{estructura.Nombre} ha generado {ingresos} recursos.");
        }
    }

    public void MejorarCiudad()
    {
        foreach (var estructura in estructuras)
        {
            estructura.Mejorar();
        }
    }
}
