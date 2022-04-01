using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej9 : MonoBehaviour
{

    //Realizá un programa que resuelva el siguiente problema:  
    //Tres personas aportan diferente capital a una sociedad.
    //Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje y cuál es el monto del total aportado  por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

        //variables
    public string per1, per2, per3;
    public double monto1, monto2, monto3;

    double monto_total, por1, por2, por3;

    // Use this for initialization
    void Start ()
    {
        monto_total = monto1 + monto2 + monto3;
        por1 = monto_total * 100 / monto1;
        por2 = monto_total * 100 / monto2;
        por3 = monto_total * 100 / monto3;

        Debug.Log(per1+": capital aportado: $"+monto1+" , Porcentaje del capital: %"+por1+" , Monto total aportado: $"+monto_total);
        Debug.Log(per2+": capital aportado: $"+monto2+" , Porcentaje del capital: %"+por2+" , Monto total aportado: $"+monto_total);
        Debug.Log(per3+": capital aportado: $"+monto3+" , Porcentaje del capital: %"+por3+" , Monto total aportado: $"+monto_total);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
