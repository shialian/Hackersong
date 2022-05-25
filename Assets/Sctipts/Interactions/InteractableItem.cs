using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EPOOutline;

public class InteractableItem : MonoBehaviour
{
    public string itemName;
    public float viewDistance;
    public Vector3 offset;
    public Sprite image;
    private Vector3 originPosition;
    private Quaternion originRotation;
    private Outlinable outline;

    public Transform[] subobjects;
    private Vector3[] originSubObjectPosition;
    private Quaternion[] originSubObjectRotation;

    public QuestType questType;
    public Vector3 targetPosition;

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

    private void Start()
    {
        outline = GetComponent<Outlinable>();
        outline.enabled = false;
    }

    public void OnPointerClick()
    {
        if (InteractionItemManager.instance.onInteraction == false)
        {
            if(questType == QuestType.QuestItem)
            {
                Quest.instance.ItemFound();
                questType = QuestType.None;
                transform.localPosition = targetPosition;
                originPosition = transform.position;
            }
            else
            {
                InteractionItemManager.instance.onInteraction = true;
                InteractionItemManager.instance.SetLaserBeamActiveState(false);
                SetOutlineable(0);
                MoveToView();
                Introduction.instance.ChangeIntroduceItem(itemName, image, questType);
                Introduction.instance.SetActivationIntroImage(true);
            }
        }
    }

    private void MoveToView()
    {
        Transform camera = GameManager.instance.vrCamera;
        transform.position = camera.position + viewDistance * camera.forward + offset;
    }

    public void OnPointerEnter()
    {
        if (InteractionItemManager.instance.onInteraction == false)
        {
            outline.enabled = true;
        }
    }

    public void OnPointerExit()
    {
        outline.enabled = false;
    }

    public void ResetItem()
    {
        MoveBack();
        SetOutlineable(OutlinableDrawingMode.Normal);
    }

    private void MoveBack()
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

    private void SetOutlineable(OutlinableDrawingMode mode)
    {
        outline.DrawingMode = mode;
    }
}
