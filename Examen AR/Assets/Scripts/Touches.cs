using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touches : MonoBehaviour {

    public GameObject cameraButton;
    public GameObject frontCameraButton;
    public GameObject screenButton;
    public GameObject processorButton;
    public GameObject memoryButton;

    public Text textbar;
    public Camera main;

    Ray ray;
    RaycastHit hit;

    void Update()
    {
        if(Input.touchCount > 0 || Input.GetTouch (0).phase == TouchPhase.Began)
        {
            ray = main.ScreenPointToRay(Input.GetTouch(0).position);

            Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(hit.collider.gameObject == cameraButton)
                {
                    InfoAboutCamera();
                }

                if (hit.collider.gameObject == frontCameraButton)
                {
                    InfoAboutFrontCamera();
                }

                if (hit.collider.gameObject == screenButton)
                {
                    InfoAboutScreen();   
                }

                if (hit.collider.gameObject == processorButton)
                {
                    InfoAboutProcessor();
                }

                if (hit.collider.gameObject == memoryButton)
                {
                    InfoAboutMemory();
                }
            }              
        }
    }


    void InfoAboutCamera()
    {
        textbar.text = "Deze camera is voorzien van een 8 megapixel camera, waarmee HD foto's gemaakt kunnen worden en 1080p Full HD video's op 30 frames per seconden.";
        cameraButton.GetComponent<TextMesh>().color = Color.blue;
        frontCameraButton.GetComponent<TextMesh>().color = Color.white;
        screenButton.GetComponent<TextMesh>().color = Color.white;
        memoryButton.GetComponent<TextMesh>().color = Color.white;
        processorButton.GetComponent<TextMesh>().color = Color.white;
    }

    void InfoAboutFrontCamera()
    {
        textbar.text = "Deze front camera oftewel de 'de selfie camera' is voorzien van een 2 Megapixel camera, waarmee selfies gemaakt kunnen worden.";
        cameraButton.GetComponent<TextMesh>().color = Color.white;
        frontCameraButton.GetComponent<TextMesh>().color = Color.blue;
        screenButton.GetComponent<TextMesh>().color = Color.white;
        memoryButton.GetComponent<TextMesh>().color = Color.white;
        processorButton.GetComponent<TextMesh>().color = Color.white;
    }

    void InfoAboutScreen()
    {
        textbar.text = "Deze telefoon bevat een scherm van 4,7 inch wat 11.94cm is, het scherm heeft een LCD display van 720p dus een HD scherm.";
        cameraButton.GetComponent<TextMesh>().color = Color.white;
        frontCameraButton.GetComponent<TextMesh>().color = Color.white;
        screenButton.GetComponent<TextMesh>().color = Color.blue;
        memoryButton.GetComponent<TextMesh>().color = Color.white;
        processorButton.GetComponent<TextMesh>().color = Color.white;
    }

    void InfoAboutProcessor()
    {
        textbar.text = "deze telefoon bevat een 1.2GHz quad core media tek processor die voor soepele prestaties zorgt, ook bevat de telefoon een 1 GB ram voor het multitasken.";
        cameraButton.GetComponent<TextMesh>().color = Color.white;
        frontCameraButton.GetComponent<TextMesh>().color = Color.white;
        screenButton.GetComponent<TextMesh>().color = Color.white;
        memoryButton.GetComponent<TextMesh>().color = Color.white;
        processorButton.GetComponent<TextMesh>().color = Color.blue;
    }

    void InfoAboutMemory()
    {
        textbar.text = "Deze telefoon bevat 4GB aan geheugen en kan worden uitgebreid met een 32GB SD kaart.";
        cameraButton.GetComponent<TextMesh>().color = Color.white;
        frontCameraButton.GetComponent<TextMesh>().color = Color.white;
        screenButton.GetComponent<TextMesh>().color = Color.white;
        memoryButton.GetComponent<TextMesh>().color = Color.blue;
        processorButton.GetComponent<TextMesh>().color = Color.white;
    }
}
