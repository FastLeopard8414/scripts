using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public int speed = 7;
    public float tiempoDeVida = 5f;
    private float tiempoDeVidaActual;


    private void Start()
    {
        tiempoDeVidaActual = tiempoDeVida;
    }
    // Update is called once per frame
    void Update()
    {
        tiempoDeVidaActual -= Time.deltaTime;
        if (tiempoDeVidaActual >= 0)
        {
            transform.position += transform.up * speed * Time.deltaTime;

        }
        else if (tiempoDeVidaActual < 0 && tiempoDeVidaActual > -5)
        {
            transform.position += transform.up * -speed * Time.deltaTime;
        }
        else if (tiempoDeVidaActual <= -5 )
        {
            tiempoDeVidaActual = tiempoDeVida;
        }


    }







    


}
