﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{

   //Realizá un programa que permita ingresar dos números enteros num1 y num2 por Inspector.
   //Luego, mostrar el resultado de la suma entre ambos al ejecutar la escena utilizando el siguiente formato: “La suma entre “ + num1 + “ y “ + num2 + “ da como resultado “ + num1 + num2.

    public int num1, num2;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("La suma entre " + num1 + " y " + num2 + " da como resultado " + num1 + num2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}