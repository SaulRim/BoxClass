using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Notes : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_InputField campo1,campo2;
    string mensaje = "";
    int valor;


    public void recuperar(string s)
    {
        mensaje = s;
        Debug.Log(mensaje);
    }

    public void HandleInputData(int val)
    {
        valor = val;
        abrir();
    }

    public void salir() {
        MainMenu.moverEscena("MainMenuScene");
    }

    public void abrir()
    {
        campo1.text = Datos.archivos[valor];
    }
    public void guardar()
    {
        Datos.archivos[valor] = campo2.text;
    }
    public void eliminar()
    {
        Datos.archivos[valor] = "";
    }
}
