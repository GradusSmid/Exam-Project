using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public Button questionButton;
    public Button backButton;
    public GameObject infoPanel;

    void Start()
    {
        questionButton.onClick.AddListener(GameInformation);
        backButton.onClick.AddListener(CloseInformation);
    }


    void GameInformation()
    {
        infoPanel.SetActive(true);
    }
    
    void CloseInformation()
    {
        infoPanel.SetActive(false);
    }
}
