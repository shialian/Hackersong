using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public string itemName;

    public void OnMouseUpAsButton()
    {
        Introduction.Instance.ChangeIntroduceItem(itemName);
    }

    public void OnPointerClick()
    {
        Introduction.Instance.ChangeIntroduceItem(itemName);
    }

    
}
