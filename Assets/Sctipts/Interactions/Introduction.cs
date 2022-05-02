using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public static Introduction Instance { get; private set; }
    private Dictionary<string, string> introductions = new Dictionary<string, string>();

    public Text subTitle;
    private string[] lines;

    private void Start()
    {
        Instance = this;
        GetIntroductionTexts();
        AddIntroductions();
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

    public void IntroduceItem(string itemName)
    {
        subTitle.text = introductions[itemName];
    }
}
