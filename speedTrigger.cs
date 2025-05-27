using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTrigger : MonoBehaviour
{
     public int velocidad= 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonMovement>())
        {
            other.GetComponent<FirstPersonMovement>().runSpeed *= velocidad;
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<FirstPersonMovement>())
        {
            other.GetComponent<FirstPersonMovement>().runSpeed /= velocidad;

        }
    }


}
 



