/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para generar de forma aleatoria los animales
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour
{
    public GameObject[] arrAnimal;
    // Start is called before the first frame update
    void Start()
    {
         // Invoca la repeticion de los animales
        InvokeRepeating("CreateAnimal", 1.5F, 1.5F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateAnimal()
    {
        // Variables para crear los rangos para la creacion de los animales
        int aleatorio = Random.Range(0, 3);
        int valX = Random.Range(-20,20);
        // Instanciacion de los animales
        Instantiate(arrAnimal[aleatorio], new Vector3(valX, transform.position.y, -10), arrAnimal[aleatorio].transform.rotation);

    }
}
