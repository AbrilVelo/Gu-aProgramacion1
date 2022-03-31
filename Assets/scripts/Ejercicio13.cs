using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    //	//Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente  manera:  
    //• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
    //• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y
    //$20  por cada hora extra. (crear una constante para almacenar el 20)
    //Ingresar por Inspector la cantidad de horas trabajadas en la semana, 
    //y mostrar por pantalla el salario correspondiente.

    public int cantidadhoras;
    void Start()
    {
        int num1 = 16;
        int num2 = 20;
        int basehoras = 40;
        int horasextras = cantidadhoras - 40;

        if (cantidadhoras <= 40)
        {
            Debug.Log("Su salario correspondido es de $" + (num1 * cantidadhoras));
        }
        else if (cantidadhoras > 40)
        {
            Debug.Log("Su salario correspondido es de $" + ((num1 * basehoras) + (num2 * horasextras)));
        }
    }

}
