using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    public int hora;
    void Start()
    {
        int HoraApertura = 10;
        int HoraCierre = 18;


        bool Hora = hora > HoraApertura && hora < HoraCierre;

        if (hora == 0 || hora > 24)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }
        else if (Hora == true)
        {
            Debug.Log("El estacionamiento se encuentra abierto");
        }
        else if (Hora == false)
        {
            Debug.Log("El estacionamiento se encuentra cerrado");
        }


    }

}
