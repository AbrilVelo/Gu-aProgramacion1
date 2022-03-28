using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    void Start()
    {
        //Realiza un programa donde se declare una variable entera, 
        //num1 que inicialmente valdrá 0.
        //Luego incrementa su valor en 2 y mostrarlo por pantalla. 
        //Después mostrar el resultado de multiplicarlo por sí mismo.

        int num1 = 0;
    int dos = 2;
    num1 += dos; 

        
        Debug.Log("resultado de su suma es " +num1); 


        Debug.Log("El resultado de la multiplicacion es " + num1* num1);


}  
}
