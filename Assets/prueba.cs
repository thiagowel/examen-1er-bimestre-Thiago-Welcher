using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Una flota de taxis tiene una cantidad determinada de unidades.
// Se calcula que cada unidad recorre unos 90 km por día y que cada litro de 
//combustible permite recorrer 15 km.Se calcula también que los días de lluvia
// se trabaja más, llegando a un recorrido de 110 km por unidad.Teniendo en 
// cuenta que el litro de combustible cuesta $130, debemos hacer un programa que
//nos permita calcular el costo del combustible para una flota completa de taxis
//en un período de días determinado.
//Se requiere el ingreso por Inspector de la cantidad de unidades que tiene la flota,
//la cantidad total de días y una cantidad de días de lluvia a tener en cuenta.
//El programa debe devolver un mensaje de error y no realizar ningún cálculo si la cantidad 
//de días total es menor que 5 o si la cantidad de días de lluvia es negativa o mayor que la 
//cantidad total de días.



public class prueba : MonoBehaviour
{
    public int lluvia;
    public int dias;
    // Start is called before the first frame update
    void Start()
    {
        if (dias < 5) 
            { 
            Debug.Log("la cantidad de días total es menor que 5");

            }
        else 
        {
       
            Debug.Log("Error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
