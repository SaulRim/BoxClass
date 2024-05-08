using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Configuraciones : MonoBehaviour
{
    public Slider slider;
    public static float sliderValue;

    void Start() {
        slider.value = 0.5f;
    }

    public void ChangeSlider() {
        sliderValue = slider.value;

    }
 
    public void moverEscena(string aux)
    {
        SceneManager.LoadScene(aux);
    }
}
