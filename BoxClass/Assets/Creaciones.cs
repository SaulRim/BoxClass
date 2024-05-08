using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creaciones : MonoBehaviour
{
    public static int tipo = 0;
    private int valor = 0;

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
