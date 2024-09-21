using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Recoleccion : Estructura
{
    public int RecursosPorTurno;

    // Constructor vac�o
    public Recoleccion() { }

    // M�todo para inicializar la clase
    public void InicializarRecoleccion(string nombre, int nivel, int recursosPorTurno)
    {
        Inicializar(nombre, nivel); // Inicializar la clase base
        RecursosPorTurno = recursosPorTurno;
    }

    // Implementaci�n del m�todo abstracto
    public override int CalcularIngresos()
    {
        return RecursosPorTurno * Nivel;
    }

    // Implementaci�n del m�todo abstracto
    public override void Operar()
    {
        Debug.Log($"{Nombre} est� recolectando {RecursosPorTurno} recursos por turno.");
    }
}
