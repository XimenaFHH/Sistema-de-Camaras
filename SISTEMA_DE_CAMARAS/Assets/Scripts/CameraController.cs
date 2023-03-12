using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public GameObject[] listaCamaras;
    public Text positionText;
    public Text rotationText;
    public Text scaleText;

    private int activeCameraIndex = 0;

    //Tenemos la función ApagarCamaras(); y activando la lsta de cámaras que pusimos 
    void Start()
    {
        ApagarCamaras();
        listaCamaras[activeCameraIndex].SetActive(true);
    }

    //Un bucle que apaga las camaras para que estas no esten activas a menos que lo necesitemos.
    void ApagarCamaras()
    {
        foreach (GameObject camara in listaCamaras)
        {
            camara.SetActive(false);
        }
    }

    void Update()
    {
        //En esta parte hacemos una un if donde marcamos que si le damos click
        //a una tecla se activara una de las vista de cámara y su respectiva información en pantalla.
        if (Input.GetKey(KeyCode.Alpha1) && activeCameraIndex != 0)
        {
            Debug.Log("Tecla 1 pulsada");
            ApagarCamaras();
            activeCameraIndex = 0;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha2) && activeCameraIndex != 1)
        {
            Debug.Log("Tecla 2 pulsada");
            ApagarCamaras();
            activeCameraIndex = 1;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha3) && activeCameraIndex != 2)
        {
            Debug.Log("Tecla 3 pulsada");
            ApagarCamaras();
            activeCameraIndex = 2;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha4) && activeCameraIndex != 3)
        {
            Debug.Log("Tecla 4 pulsada");
            ApagarCamaras();
            activeCameraIndex = 3;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha5) && activeCameraIndex != 4)
        {
            Debug.Log("Tecla 5 pulsada");
            ApagarCamaras();
            activeCameraIndex = 4;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha6) && activeCameraIndex != 5)
        {
            Debug.Log("Tecla 6 pulsada");
            ApagarCamaras();
            activeCameraIndex = 5;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        if (Input.GetKey(KeyCode.Alpha7) && activeCameraIndex != 6)
        {
            Debug.Log("Tecla 7 pulsada");
            ApagarCamaras();
            activeCameraIndex = 6;
            listaCamaras[activeCameraIndex].SetActive(true);
        }

        // Activar la camara 
        Camera activeCamera = listaCamaras[activeCameraIndex].GetComponent<Camera>();

        // Esto nos permite mostrar la información en la pantalla.
        positionText.text = "Position: " + activeCamera.transform.position.ToString();
        rotationText.text = "Rotation: " + activeCamera.transform.rotation.eulerAngles.ToString();
        scaleText.text = "Scale: " + activeCamera.transform.localScale.ToString();
    }
}


