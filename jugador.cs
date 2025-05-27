using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugador : MonoBehaviour
{
    int monedas;
    public AudioSource altavozSonidoMonedas;
    public AudioClip sonidoMoneda;
    public AudioClip damagesound;
    public GameObject fireballPrefab;
    public Transform atackPoint;
    private int health = 200;
    
    public void cogerMonedas()

    {

        monedas++;
        altavozSonidoMonedas.PlayOneShot(sonidoMoneda);
    }

    
    public void TakeDamage(int damage )
    {
        health -= damage;
        print("Player´s health: " + health);

        if (health > 0)
        {
            altavozSonidoMonedas.PlayOneShot(damagesound);
        }
        else
        {
            SceneManager.LoadScene("game over");
        }

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, atackPoint.position, atackPoint.rotation);
        }
    }
}     
    