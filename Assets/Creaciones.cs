using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Creaciones : MonoBehaviour
{
    public static int tipo = 0;
    private int valor = 0;

    public Slider slider;

    void Start()
    {
        slider.value = 1f;
    }

    public void ChangeSlider()
    {
        Debug.Log(slider.value);
        if(slider.value == 0) {
            Datos.rotacion = 60f;
        }
        if (slider.value == 1)
        {
            Datos.rotacion = 150f;
        }
        if (slider.value == 2)
        {
            Datos.rotacion = -25f;
        }

    }

    public void HandleInputData(int val) {
        valor = val;
    }
    public void accept() {
        tipo = valor;
    }
    public void moverEscena(string aux)
    {
        SceneManager.LoadScene(aux);
    }

}
