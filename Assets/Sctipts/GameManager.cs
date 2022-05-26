using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Canvas vrCanvas;
    public Transform vrCamera;
    public AudioClip clip;

    private void Start()
    {
        instance = this;
        Initialize();
    }

    private void Initialize()
    {
        vrCanvas.gameObject.SetActive(false);
    }

    public void GameStart()
    {
        vrCanvas.gameObject.SetActive(true);
        Dialogue.instance.PlayClip(clip);
    }
}
