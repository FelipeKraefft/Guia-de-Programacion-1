using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{

    //Crear una variable entera que pueda ser modificada desde el Inspector.
    //Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al valor de la variable “dia”. 
    //Si el día no está en el rango  permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 


    public int dia;
    // Use this for initialization
	void Start ()
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
                Debug.Log("El día ingresado no es valido");
                break;
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
