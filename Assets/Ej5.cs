using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5 : MonoBehaviour
{

    //Realizá un programa que, dados dos números enteros num1 y num2 cargados desde el Inspector
    //muestre el resultado de la división del primero por el segundo en la consola siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.
    //En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:  “No se puede dividir por cero”. 

    public int num1, num2;
    // Use this for initialization
    void Start ()
    {
        int resultado = num1 / num2;

	if (num2 != 0)
        {
            Debug.Log(num1 + " / " + num2 +" = " + resultado);
        }
        else
        {
            Debug.Log("Error: no se puede dividir por 0");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
