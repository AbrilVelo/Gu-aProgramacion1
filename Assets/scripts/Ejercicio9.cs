using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema:  

    //Tres personas aportan diferente capital a una sociedad.
    //Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) 
    //y cuál es el monto del total aportado  por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas 
    //y luego  mostrar lo pedido en el siguiente formato:  
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

    public string Nombre1; public float capital1;
    public string Nombre2; public float capital2;
    public string Nombre3; public float capital3;

    void Start()
    {

        float montototal = capital1 + capital2 + capital3;
        float porcentaje1; float porcentaje2; float porcentaje3;

        porcentaje1 = (capital1 * 100) / montototal;
        porcentaje2 = (capital2 * 100) / montototal;
        porcentaje3 = (capital3 * 100) / montototal;

        Debug.Log("Nombre " + Nombre1 + ", capital aportado: $" + capital1 + ", porcentaje del capital: %" + porcentaje1 + ", monto total aportado: $" + montototal);
        Debug.Log("Nombre " + Nombre2 + ", capital aportado: $" + capital2 + ", porcentaje del capital: %" + porcentaje2 + ", monto total aportado: $" + montototal);
        Debug.Log("Nombre " + Nombre3 + ", capital aportado: $" + capital3 + ", porcentaje del capital: %" + porcentaje3 + ", monto total aportado: $" + montototal);
    }



}
