using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    LayerMask mask;
    public float distancia = 1.5f;

    public Texture2D puntero;
    public GameObject TextDetect;
    public GameObject pantalla;
    GameObject ultimoReconocido = null;

    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        TextDetect.SetActive(false);
        pantalla.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // RayCast Rayo para detectar a que apuntas (or,dis,out,dis,masc)
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            if (hit.collider.tag == "interactivo")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    pantalla.gameObject.SetActive(true);
                    hit.collider.transform.GetComponent<Objetointeractivo>().ActivarObjeto();
                }

            }
        }
        else {
            Deselect();
        }



    }

    public void cierre() {
        pantalla.gameObject.SetActive(false);
    }

    void SelectedObject(Transform transform)
    {
        //transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultimoReconocido = transform.gameObject;
    }

    void Deselect()
    {
        if (ultimoReconocido)
        {
            //ultimoReconocido.GetComponent<Renderer>().material.color = Color.white;
            ultimoReconocido = null;
        }

    }

    void OnGUI()
    {
        Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width, puntero.height);
        GUI.DrawTexture(rect, puntero);
        if (ultimoReconocido)
        {
            TextDetect.SetActive(true);
        }
        else
        {
            TextDetect.SetActive(false);
        }
    }
}
