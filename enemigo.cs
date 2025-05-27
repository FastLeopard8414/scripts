using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigo : MonoBehaviour
{
    public int health = 80;
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
        if (other.GetComponent<jugador>())
        {
            jugador jugador = other.GetComponent<jugador>();
            jugador.TakeDamage(jugadorDamage);
        }
    }

    public void TakeEnemyDamage(int damage)
    {
        health -= damage;
        print("Player´s health: " + health);

        if (health > 0)
        {
            
        }
        else
        {
            Destroy(gameObject);
        }

    }
}