using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionSwitcher : MonoBehaviour
{
    
    public GameObject pcControllers;
    public GameObject vrControllers;
    private UserType type;

    private void Update()
    {
        type = GameManager.instance.type;
        Switch();
    }

    private void Switch()
    {
        switch (type)
        {
            case UserType.PC:
                if (pcControllers.activeSelf == false)
                {
                    pcControllers.SetActive(true);
                    vrControllers.SetActive(false);
                }
                break;
            case UserType.VR:
                if (vrControllers.activeSelf == false)
                {
                    vrControllers.SetActive(true);
                    pcControllers.SetActive(false);
                }
                break;
        }
    }
}
