using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum UserType
{
    PC,
    VR
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UserType type;
    public Canvas pcCanvas;
    public Canvas vrCanvas;
    private Canvas currentCanvas;

    private void Start()
    {
        instance = this;
        Initialize();
    }

    private void Initialize()
    {
        switch (type)
        {
            case UserType.PC:
                currentCanvas = pcCanvas;
                break;
            case UserType.VR:
                currentCanvas = vrCanvas;
                break;
        }
        currentCanvas.gameObject.SetActive(false);
    }

    public void GameStart()
    {
        currentCanvas.gameObject.SetActive(true);
    }
}
