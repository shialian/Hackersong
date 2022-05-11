using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class SkyboxBlender : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject destination;
    [SerializeField]
    private bool inblending = false;
    private float timer = 0f;

    private void Start()
    {
        BlendSkybox(0f);
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch)){
            inblending = true;
            destination.SetActive(false);
        }
        if (inblending)
        {
            SetTimer();
            BlendSkybox(timer);
        }
    }

    private void SetTimer()
    {
        timer += speed * Time.deltaTime;
        timer = Mathf.Min(timer, 1f);
    }

    private void BlendSkybox(float blend)
    {
        
        RenderSettings.skybox.SetFloat("_Blend", blend);
        if(speed * Time.time == 1f)
        {
            inblending = false;
        }
    }
}
