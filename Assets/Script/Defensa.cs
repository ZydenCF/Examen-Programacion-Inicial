using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Defensa : Estructura
{
    public int PuntosDeDefensa { get; set; }

    public void InicializarDefensa(string nombre, int nivel, int puntosDeDefensa)
    {
        Inicializar(nombre, nivel);
        PuntosDeDefensa = puntosDeDefensa;
    }

    public override int CalcularIngresos()
    {
        return 0;
    }

    public override void Operar()
    {
        Debug.Log($"{Nombre} está defendiendo con {PuntosDeDefensa * Nivel} puntos de defensa.");
    }
}
