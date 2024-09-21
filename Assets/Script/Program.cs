using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Program
{
    static void Main(string[] args)
    {
        Juego juego = new Juego();

        Recoleccion mina = new Recoleccion();
        mina.InicializarRecoleccion("Mina de Oro", 1, 10);
        juego.AgregarEstructura(mina);
        juego.OperarCiudad();

        juego.MejorarCiudad();
        juego.OperarCiudad();
    }
}
