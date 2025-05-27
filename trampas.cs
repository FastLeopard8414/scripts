using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampas : MonoBehaviour
{
    public int jugadorDamage = 40;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<jugador>())
        {
            jugador jugador = other.GetComponent<jugador>();
            jugador.TakeDamage(jugadorDamage);
        }
            
    }
}
