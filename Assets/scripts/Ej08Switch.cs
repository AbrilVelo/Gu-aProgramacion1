using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08Switch : MonoBehaviour
{
    public int dia;
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Lunes");
                break;
            case 3:
                Debug.Log("Martes");
                break;
            case 4:
                Debug.Log("Miercoles");
                break;
            case 5:
                Debug.Log("Jueves");
                break;
            case 6:
                Debug.Log("Viernes");
                break;
            case 7:
                Debug.Log("Sabado");
                break;
            default:
                Debug.Log("Día ingresado no es válido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
