using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public void SetHealthBar(int Health)
    {
        slider.value = Health;
    }
}
