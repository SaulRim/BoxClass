using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Perfil : MonoBehaviour
{
    public TMP_InputField campo1;
    public TMP_InputField campo2;
    public TMP_InputField campo3;
    public TMP_InputField campo4;

    void Start() {
        campo1.text = Datos.nombre;
        campo2.text = Datos.apellidoP;
        campo3.text = Datos.apellidoM;
        campo4.text = Datos.correo;

    }

    public void datos()
    {
        Datos.nombre = campo1.text;
        Datos.apellidoP = campo2.text;
        Datos.apellidoM = campo3.text;
        Datos.correo = campo4.text;
        MainMenu.moverEscena("MainMenuScene");
    }

}
