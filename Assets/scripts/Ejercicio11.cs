using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    // Realizá un programa que resuelva el siguiente problema:  
    //Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD),
    //un nombre de comprador, un nombre de producto y una cantidad y precio del producto comprado.
    //Mostrá a modo de ticket, la información ingresada y el monto a pagar.Modelo de Ticket:  
    //Fecha de Compra: YYYYMMDD
    // Nombre del Comprador: xxxxx xxxxx
    // Producto solicitado: xxxxx
    // Cantidad solicitada: xx
    // Precio Unitario: $xxx
    // Total a Pagar: $xxxxx

    public string YYYYMMDD;
    public string NombreComprador;
    public string NombreProducto;
    public float Cantidad;
    public float PrecioProducto;
    void Start()
    {
        float Total = Cantidad * PrecioProducto;

        Debug.Log("Fecha de Compra: " + YYYYMMDD);
        Debug.Log("Nombre del comprador: " + NombreComprador);
        Debug.Log("Producto solicitado: " + NombreProducto);
        Debug.Log("Cantidad solicitada: " + Cantidad);
        Debug.Log("Precio Unitario: " + PrecioProducto);
        Debug.Log("Total a pagar: " + Total);
    }

}
