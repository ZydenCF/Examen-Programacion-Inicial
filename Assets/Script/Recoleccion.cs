using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Recoleccion : Estructura
{
    public int RecursosPorTurno;

    // Constructor vacío
    public Recoleccion() { }

    // Método para inicializar la clase
    public void InicializarRecoleccion(string nombre, int nivel, int recursosPorTurno)
    {
        Inicializar(nombre, nivel); // Inicializar la clase base
        RecursosPorTurno = recursosPorTurno;
    }

    // Implementación del método abstracto
    public override int CalcularIngresos()
    {
        return RecursosPorTurno * Nivel;
    }

    // Implementación del método abstracto
    public override void Operar()
    {
        Debug.Log($"{Nombre} está recolectando {RecursosPorTurno} recursos por turno.");
    }
}
