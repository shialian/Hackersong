using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public OVRInput.Button vrShutter;
    public OVRInput.Controller shutTouch;
    public KeyCode pcShutter;

    private void Update()
    {
        if(OVRInput.GetDown(vrShutter, shutTouch) || Input.GetKeyDown(pcShutter))
        {
            string dateTime = System.DateTime.Now.ToString();
            dateTime = dateTime.Replace('/', '-');
            dateTime = dateTime.Replace(':', '-');
            ScreenCapture.CaptureScreenshot("Assets/ScreenShots/" + dateTime + ".png");
        }
    }
}
