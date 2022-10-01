/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para el movimiento de los animales
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalController : MonoBehaviour
{
    float limite = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Funcion para destruir a los animales cuando cruce el limite
        if(transform.position.z < -limite){
            Destroy(gameObject);
        }

        // se configura el movimiento de los animales
        transform.Translate(Vector3.forward*Time.deltaTime*15);   
    }
}
