using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionItemManager : MonoBehaviour
{
    public static InteractionItemManager instance;
    public InteractableItem[] items;
    public GameObject laserBeam;
    public bool onInteraction;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch) && onInteraction)
        {
            ResetInroductions();
        }
    }

    public void ResetInroductions()
    {
        onInteraction = false;
        Introduction.instance.SetActivationIntroImage(false);
        SetLaserBeamActiveState(true);
        ResetItemsPosition();
        Introduction.instance.ResetSubtitle();
    }

    public void ResetItemsPosition()
    {
        for(int i = 0; i < items.Length; i++)
        {
            if (items[i].questType != QuestType.QuestItem)
            {
                items[i].ResetItem();
            }
        }
    }

    public void SetLaserBeamActiveState(bool flag)
    {
        laserBeam.SetActive(flag);
    }
}
