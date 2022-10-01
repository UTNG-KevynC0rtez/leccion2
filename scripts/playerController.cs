/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Cortez Ramirez Jose Kevyn
* Fecha: 28 de septiembre del 2022
* Funcion de Script: El script es para el movimiento del granjero, se movera en su eje X. 
  Tambien es para declarar los alimentos que seran lanzados
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject proyectilFood;
    private float horizontalInput;
    private float speed = 10.0f;
    private float limite = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Funcion para moverse sobre el eje x
        if(transform.position.x > limite){
            transform.position = new Vector3(limite,transform.position.y, transform.position.z);
        }
        // Funcion para moverse sobre el eje x
        if(transform.position.x < -limite){
            transform.position = new Vector3(-limite, transform.position.y, transform.position.z);
        }
        // Movilidad del player de manera horizontal
         horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);  
         // Funcion para instanciar los alimentos
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(proyectilFood, transform.position, proyectilFood.transform.rotation);
        }
    }
}
