using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public static Introduction Instance { get; private set; }
    private Dictionary<string, string> introductions = new Dictionary<string, string>();

    public Text pcSubTitle;
    public Text vrSubTitle;
    private Text currentSubTitle;
    private string[] currentText;
    private int textIndex;
    private string[] lines;

    private void Start()
    {
        Instance = this;
        SwitchSubtitle();
        GetIntroductionTexts();
        AddIntroductions();
    }

    private void SwitchSubtitle()
    {
        switch (GameManager.instance.type)
        {
            case UserType.PC:
                currentSubTitle = pcSubTitle;
                break;
            case UserType.VR:
                currentSubTitle = vrSubTitle;
                break;
        }
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
            if(line[i] == '¡G')
            {
                return i;
            }
        }
        return -1;
    }

    public void ChangeIntroduceItem(string itemName)
    {
        currentText = introductions[itemName].Split('¡A','¡F');
        textIndex = 0;
        ChangeSubtitle();
        SetNextTextIndex(1);
    }

    private void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            if(textIndex < currentText.Length)
            {
                ChangeSubtitle();
                SetNextTextIndex(1);
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            if (textIndex >= 0)
            {
                ChangeSubtitle();
                SetNextTextIndex(-1);
            }
        }
    }

    private void ChangeSubtitle()
    {
        currentSubTitle.text = currentText[textIndex];
    }

    private void SetNextTextIndex(int next)
    {
        textIndex += next;
    }
}
