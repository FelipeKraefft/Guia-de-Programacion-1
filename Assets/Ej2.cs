﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    //2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
    //a.Suma
    //b.Producto

    int num1 = 4;
    int num2 = 5;
    // Use this for initialization
    void Start ()
    {
        int suma = num1 + num2;
        int producto = num1 * num2;
        Debug.Log(suma);
        Debug.Log(producto);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
