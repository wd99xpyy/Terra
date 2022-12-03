using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class healthbar : MonoBehaviour
{
    public Slider mainSlider;
    public void SetHealth(int health)
    {
        mainSlider.value = health;
    }
    public void SetMaxHealth(int maxHealth)
    {
        mainSlider.maxValue = maxHealth;
    }
}
