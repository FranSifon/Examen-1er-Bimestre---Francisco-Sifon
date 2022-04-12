using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public int campo;
    public int platea;

    void Start()
    {
        int recaudacion_campo;
        int recaudacion_platea;
        int recaudacion_completa;
        int entradas_completa;

        entradas_completa = campo + platea;

        recaudacion_campo = campo * 1200;

        recaudacion_platea = platea * 2000;

        recaudacion_completa = recaudacion_campo + recaudacion_platea;

        if (campo > 20400 || platea > 16200 || campo < 0 || platea < 0)
        {
            Debug.Log(" Por favor, ingrese un valor correspondiente, el maximo de entradas para el campo son 20400 entradas, y para platea 16200, recuerde que no puede ingresar un valor menor a 0 ");
        }
        else
        { 
        if (campo <= 20400 || platea <= 16200 || campo < 0 || platea < 0)
        {
            Debug.Log(" Lo recaudado con la venta de entradas de campo es de " + recaudacion_campo + " pesos argentinos, y la recaudacion de la venta de entradas de platea es de " + recaudacion_platea + " pesos argentinos, esto nos da un total de " + recaudacion_completa + " pesos argentinos");

        }



        if (entradas_completa == 36600)
        {
            Debug.Log(" Sold out! ");
        }
        else if ( entradas_completa < 36600 )
        {
            int vacante;
            vacante = 36600 - entradas_completa;
            Debug.Log(" Se vendieron un total de " + entradas_completa + " entradas, por ende quedaron vacantes " + vacante + " entradas");

        }
        if ( entradas_completa > 18300)
        {
            Debug.Log(" El recital fue un exito, se supero la mitad de la capacidad ");
        }
        else
        {
            Debug.Log(" No se supero la mitad de la capacidad del predio, debemos mejorar la convocatoria");

        }
    }






}

    // Update is called once per frame
    void Update()
    {
        
    }
}
