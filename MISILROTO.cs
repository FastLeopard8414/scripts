using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MISILROTO : MonoBehaviour
{
    public int enemigoDamage = 40;
    public int speed;
    public float tiempoDeVida = 6f;
    private float tiempoDeVidaActual;
    // Update is called once per frame

    private void Start()
    {
        tiempoDeVidaActual = tiempoDeVida;
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        tiempoDeVidaActual -= 1 * Time.deltaTime;
        if (tiempoDeVidaActual <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<enemigo>())
        {
            enemigo enemigo = other.GetComponent<enemigo>();
            enemigo.TakeEnemyDamage(enemigoDamage);
        }
    }
}
