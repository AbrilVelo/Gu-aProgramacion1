﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    // Construir un programa que simule el funcionamiento de una calculadora que puede 
    //realizar las cuatro operaciones aritméticas básicas 
    //(suma, resta, producto y división) con  valores numéricos enteros.  
    //Se debe especificar la operación que se desea realizar 
    //ingresando una letra por Inspector
    //(s para la suma, r para la resta, p para el producto y d para la división) 
    //y luego, deberán ingresarse dos números enteros para así realizar la operación.
    //Informar el resultado por pantalla.Nota: Se recomienda el empleo de una sentencia switch. 

    public float num1;
    public float num2;
    public string operador;
    void Start()
    {
        switch (operador)
        {
            case "s":
                Debug.Log(num1 + num2);
                break;
            case "r":
                Debug.Log(num1 - num2);
                break;
            case "p":
                Debug.Log(num1 * num2);
                break;
            case "d":
                Debug.Log(num1 / num2);
                break;
        }

    }

}