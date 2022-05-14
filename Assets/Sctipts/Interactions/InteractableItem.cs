using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public string itemName;
    public float viewDistance;
    public Vector3 offset;
    private Vector3 originPosition;
    private Quaternion originRotation;

    public Transform[] subobjects;
    private Vector3[] originSubObjectPosition;
    private Quaternion[] originSubObjectRotation;

    private void Awake()
    {
        originPosition = transform.position;
        originRotation = transform.rotation;
        if(subobjects.Length > 0)
        {
            originSubObjectPosition = new Vector3[subobjects.Length];
            originSubObjectRotation = new Quaternion[subobjects.Length];
            for(int i = 0; i < subobjects.Length; i++)
            {
                originSubObjectPosition[i] = subobjects[i].position;
                originSubObjectRotation[i] = subobjects[i].rotation;
            }
        }
    }

    public void OnPointerClick()
    {
        InteractionItemManager.instance.SetLaserBeamActiveState(false);
        MoveToView();
        Introduction.Instance.ChangeIntroduceItem(itemName);
    }

    private void MoveToView()
    {
        Transform camera = GameManager.instance.vrCamera;
        transform.position = camera.position + viewDistance * camera.forward + offset;
    }

    public void MoveBack()
    {
        if (transform.position != originPosition)
        {
            transform.position = originPosition;
            transform.rotation = originRotation;
        }
        if (subobjects.Length > 0)
        {
            for (int i = 0; i < subobjects.Length; i++)
            {
                subobjects[i].position = originSubObjectPosition[i];
                subobjects[i].rotation = originSubObjectRotation[i];
            }
        }
    }
}
