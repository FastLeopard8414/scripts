using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public jugador jugador;
    public TextMeshProUGUI monedaCounterText;
    public Slider healthSlider;

    private void Update()
    {
       
        healthSlider.maxValue  = jugador.Maxvida;
        healthSlider.value = jugador.health;
        monedaCounterText.text = jugador.monedas.ToString();
    }
    



}