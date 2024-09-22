using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Program : MonoBehaviour
{
    static void Main(string[] args)
    {
        Cuidad cuidad = new Cuidad();

        // Agregar construcciones
        Recoleccion granero = new Recoleccion("Granero", 1, 5, 10);
        Defensa muralla = new Defensa("Muralla", 1, 8, 15);

        cuidad.AgregarConstruccion(granero);
        cuidad.AgregarConstruccion(muralla);

        // Ejecutar varios turnos
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Turno {i + 1}");
            cuidad.EjecutarTurno();

            // Mostrar valores después del turno
            Console.WriteLine($"Recursos generados por el granero: {granero.ObtenerRecursosGenerados()}");
            Console.WriteLine($"Fuerza defensiva de la muralla: {muralla.ObtenerFuerzaDefensiva()}");
            Console.WriteLine($"Recursos restantes en la ciudad: {cuidad.EjecutarTurno()}");
        }
    }
}
