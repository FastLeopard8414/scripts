using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fusil : MonoBehaviour
{

    public float speed;
    public Transform target;
    public int jugadorDamage = 80;

    // Update is called once per frame
    void Update()
    {
        transform.position =
             Vector3.MoveTowards(transform.position,
             target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);

    }

    private void OnTriggerEnter(Collider other)
    {
        jugador jugador = other.GetComponent<jugador>();
        jugador.TakeDamage(jugadorDamage);
    }
}
