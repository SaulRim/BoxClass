using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio : MonoBehaviour
{
    public GameObject camara1, camara2;
    // Start is called before the first frame update
    void Start()
    {
        camara2.gameObject.SetActive(false);
        camara1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) {
            Debug.Log("Tecla 1");
            camara1.gameObject.SetActive(true);
            camara2.gameObject.SetActive(false);
        } else if (Input.GetKey(KeyCode.Alpha2))
        {
            Debug.Log("Tecla 1");
            camara1.gameObject.SetActive(false);
            camara2.gameObject.SetActive(true);
        }
    }
}
