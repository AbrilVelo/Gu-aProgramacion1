using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public int num;

    void Start()
    {

        bool estaEnA = num < 10;
        bool estaEnB = num % 2 != 0;
        bool estaEnAmbos = estaEnB && estaEnA;
        bool noEstaEnNinguno = num % 2 == 0 && num > 10;

        if (estaEnB == true && estaEnA == false) // impar y que no es de un digito
        {
            Debug.Log("Pertenece al segundo conjunto");
        }
        else if (estaEnAmbos) // impar  y que es de un digito
        {
            Debug.Log("Pertenece a ambos conjuntos");
        }

        else if (estaEnA == true && estaEnB == false) // un solo digito y que no es impar
        {
            Debug.Log("Pertenece al primer conjunto");
        }

        else if (noEstaEnNinguno) //ninguno de los dos
            Debug.Log("No pertenece a ningun conjunto");
    }



}
