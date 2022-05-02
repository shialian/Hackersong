using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteractableItem : MonoBehaviour
{
    public string itemName;

    private void OnMouseUpAsButton()
    {
        Introduction.Instance.IntroduceItem(itemName);
    }
}
