using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private SoundManager soundManager;
    private void Awake() {
        soundManager = FindObjectOfType<SoundManager>();
    }

    void Start() {
        soundManager.SeleccionAudio(1, Configuraciones.sliderValue);
    }

    public static void moverEscena(string aux) {
        SceneManager.LoadScene(aux);
    }

    public void Exit() {
        Application.Quit();
    }
}
