using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas mainCanvas;
    public TMP_InputField playerNameInput;
    string playerName = null;

    private void Awake()
    {
        
    }
    public void InputName()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        //playerName = playerNameInput.text;
        //PlayerPrefs.SetString("CurrentPlayerName", playerName);
        OffMainCanvas();
    }

    public void OffMainCanvas()
    {
        mainCanvas.gameObject.SetActive(false);
    }
}
