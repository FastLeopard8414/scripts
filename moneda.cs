using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<jugador>())
        {
            jugador variableJugador = other.GetComponent<jugador>();
            variableJugador.cogerMonedas();

            Destroy(gameObject);
        }
    }
}
