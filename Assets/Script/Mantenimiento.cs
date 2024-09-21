using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Mantenimiento : Estructura, IMantenimiento
{
    public int CostoMantenimiento { get; set; }

    public void InicializarMantenimiento(string nombre, int nivel, int costoMantenimiento)
    {
        Inicializar(nombre, nivel);
        CostoMantenimiento = costoMantenimiento;
    }

    public override int CalcularIngresos()
    {
        return 0;
    }

    public override void Operar()
    {
        Debug.Log($"{Nombre} está operando y requiere mantenimiento.");
    }

    public void RealizarMantenimiento()
    {
        Debug.Log($"{Nombre} ha realizado el mantenimiento, costo: {CostoMantenimiento * Nivel}.");
    }
}
