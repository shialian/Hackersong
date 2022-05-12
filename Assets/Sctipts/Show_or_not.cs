using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_or_not : MonoBehaviour
{
    public GameObject obj;
    public float delaytime = 0;
    public void InvokeShow()
    {
        Invoke("show", delaytime);
    }
    public void InvokeDisappear()
    {
        Invoke("disappear", delaytime);
    }
   public void show()
    {
        obj.SetActive(true);
    }
    public void disappear()
    {
        obj.SetActive(false);
    }
}
