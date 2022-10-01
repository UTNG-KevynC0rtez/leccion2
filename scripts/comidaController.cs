/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para el movimiento de la comida
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comidaController : MonoBehaviour
{
    public float distance = 15;
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Funcion para destruir el alimento cuando haga contacto con el animal
        if(transform.position.z > distance) {
            Destroy(gameObject);
        }  
       
        // configurar el movimiento de la comida
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
