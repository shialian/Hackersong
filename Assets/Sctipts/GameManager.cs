using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Canvas canvas;

    private void Start()
    {
        instance = this;
        Initialize();
    }

    private void Initialize()
    {
        canvas.gameObject.SetActive(false);
    }

    public void GameStart()
    {
        canvas.gameObject.SetActive(true);
    }
}
