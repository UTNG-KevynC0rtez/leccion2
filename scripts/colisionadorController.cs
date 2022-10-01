/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para cuando el alimento haga contacto con algun animal se destruya
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionadorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        // Función de colición para destruir objetos
    void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
    }
}
