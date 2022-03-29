using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6 : MonoBehaviour
{

    //Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
    //en una variable llamada num1 y muestre un mensaje por pantalla indicando "el  número es par" o "el número es impar". 
    //Deberá utilizar el operador “módulo” es el caracter  %.

    public int num1;

	// Use this for initialization
	void Start ()
    {
        int modulo = num1 % 2;

		if (num1 > 0 && modulo == 0)
        {
            Debug.Log("El número es par");
        }
        else if (num1 > 0 && modulo == 1)
        {
            Debug.Log("El número es impar");
        }
        else
        {
            Debug.Log("Algo salio mal");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
