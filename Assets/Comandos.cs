using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comandos : MonoBehaviour
{
    // Variables
    public Camera cam;
    public float mouseHorizontal = 2.0f;
    public float mouseVertical = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;
    float x, y;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = mouseHorizontal * Input.GetAxis("Mouse X");
        y += mouseVertical * Input.GetAxis("Mouse Y");

        cam.transform.localEulerAngles = new Vector3(-y,0,0);
        transform.Rotate(0, x, 0);
        y = Mathf.Clamp(y, minRotation, maxRotation);

    }
}
