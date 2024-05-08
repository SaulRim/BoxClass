using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Loggin : MonoBehaviour
{
    public TMP_InputField campo1;
    //public TextMeshProUGUI password;

    public void guardar()
    {
        //password.text = campo1.text;
        Datos.correo = campo1.text;
        MainMenu.moverEscena("MainMenuScene");
    }
}
