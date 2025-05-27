using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolin : MonoBehaviour
{
    public int jump = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Jump>())
        {
            other.GetComponent<Jump>().jumpStrength *= jump;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Jump>())
        {

            other.GetComponent<Jump>().jumpStrength /= jump;
        }


    }

}

