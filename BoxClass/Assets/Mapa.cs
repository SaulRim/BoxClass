using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{

    
    void Start()
    {
        soundManager.SeleccionAudio(Creaciones.tipo, Configuraciones.sliderValue);
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            MainMenu.moverEscena("MainMenuScene");
        }
    }
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    private SoundManager soundManager;
}
