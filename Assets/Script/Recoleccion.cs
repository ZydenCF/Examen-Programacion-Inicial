using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Recoleccion : Estructura
{
    public int RecursosPorTurno;

    public Recoleccion() { }

    public void InicializarRecoleccion(string nombre, int nivel, int recursosPorTurno)
    {
        Inicializar(nombre, nivel); 
        RecursosPorTurno = recursosPorTurno;
    }

    public override int CalcularIngresos()
    {
        return RecursosPorTurno * Nivel;
    }

    public override void Operar()
    {
        Debug.Log($"{Nombre} está recolectando {RecursosPorTurno} recursos por turno.");
    }
}
