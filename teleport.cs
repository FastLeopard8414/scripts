using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teletransporte;
    bool estalistoparateletransportarse = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<jugador>() & estalistoparateletransportarse)
        {
            other.transform.position = teletransporte.position;
            estalistoparateletransportarse = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<jugador>())
        {
            estalistoparateletransportarse = true;

        }
    }
}