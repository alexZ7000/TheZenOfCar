using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public GameObject eventSystem2;

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (health <=0)
        {
            health = 0;
            eventSystem2.SetActive(false);
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("CenaRecuperada");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Morte");
        }
    }
}