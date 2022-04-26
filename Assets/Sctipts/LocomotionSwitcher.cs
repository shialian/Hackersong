using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionSwitcher : MonoBehaviour
{
    public enum LocomotionType
    {
        PC,
        VR
    }
    public LocomotionType type;
    public GameObject pcControllers;
    public GameObject vrControllers;

    private void Update()
    {
        Switch();
    }

    private void Switch()
    {
        switch (type)
        {
            case LocomotionType.PC:
                if (pcControllers.activeSelf == false)
                {
                    pcControllers.SetActive(true);
                    vrControllers.SetActive(false);
                }
                break;
            case LocomotionType.VR:
                if (vrControllers.activeSelf == false)
                {
                    vrControllers.SetActive(true);
                    pcControllers.SetActive(false);
                }
                break;
        }
    }
}
