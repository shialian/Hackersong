using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionItemManager : MonoBehaviour
{
    public static InteractionItemManager instance;
    public InteractableItem[] items;
    public GameObject laserBeam;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            SetLaserBeamActiveState(true);
            ResetItemsPosition();
            Introduction.Instance.ResetSubtitle();
        }
    }

    public void ResetItemsPosition()
    {
        for(int i = 0; i < items.Length; i++)
        {
            items[i].MoveBack();
        }
    }

    public void SetLaserBeamActiveState(bool flag)
    {
        laserBeam.SetActive(flag);
    }
}
