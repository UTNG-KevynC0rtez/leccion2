/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para que se destruyan todos los elementos que salgan de la escena
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyController : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBoun = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.z > topBound)
       {
        Destroy(gameObject);
       } else if (transform.position.z < lowerBoun)
       {
        Destroy(gameObject);
       }
    }
}
