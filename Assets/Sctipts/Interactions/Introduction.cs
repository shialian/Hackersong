using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public static Introduction Instance { get; private set; }
    private Dictionary<string, string> introductions = new Dictionary<string, string>();

    public Text vrSubTitle;
    private string[] currentText;
    private int textIndex;
    private string[] lines;
    private string defaultTitle = "請點選茶桌上的茶具";

    public Image image;

    private void Start()
    {
        Instance = this;
        GetIntroductionTexts();
        AddIntroductions();
        SetActivationIntroImage(false);
    }

    private void GetIntroductionTexts()
    {
        StreamReader reader = new StreamReader("Introductions.txt");
        string text = reader.ReadToEnd();
        lines = text.Split('\n');
    }

    private void AddIntroductions()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            int length = GetItemNameLength(lines[i]);
            if (length > 0)
            {
                introductions[lines[i].Substring(0, length)] = lines[i].Substring(length + 1);
            }
        }
    }

    private int GetItemNameLength(string line)
    {
        for(int i = 0; i < line.Length; i++)
        {
            if(line[i] == '：')
            {
                return i;
            }
        }
        return -1;
    }

    public void SetActivationIntroImage(bool flag)
    {
        image.gameObject.SetActive(flag);
    }

    public void ChangeIntroduceItem(string itemName)
    {
        currentText = introductions[itemName].Split('，','；');
        textIndex = 0;
        ChangeSubtitle();
    }

    private void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && vrSubTitle.text != defaultTitle)
        {
            if(textIndex < currentText.Length - 1)
            {
                SetNextTextIndex(1);
                ChangeSubtitle();
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch) && vrSubTitle.text != defaultTitle)
        {
            if (textIndex > 0)
            {
                SetNextTextIndex(-1);
                ChangeSubtitle();
            }
        }
    }

    private void ChangeSubtitle()
    {
        vrSubTitle.text = currentText[textIndex];
    }

    private void SetNextTextIndex(int next)
    {
        textIndex += next;
    }

    public void ResetSubtitle()
    {
        vrSubTitle.text = defaultTitle;
    }
}
