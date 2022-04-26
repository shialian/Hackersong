using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestBoard : MonoBehaviour
{
    public static QuestBoard Instance { get; private set; }
    public Quest[] quests;
    public Text text;

    public AudioSource audioSource;
    public AudioClip correct;
    public AudioClip incorrect;

    private void Start()
    {
        Instance = this;
        AssignQuestNumberToQuest();
    }

    private void AssignQuestNumberToQuest()
    {
        for(int i = 0; i < quests.Length; i++)
        {
            quests[i].questNumber = i;
        }
    }

    public void AnswerCheck(int questNumber, Option option)
    {
        if(option == quests[questNumber].answer)
        {
            audioSource.PlayOneShot(correct);
            text.text = "µª¹ïÅo";
        }
        else
        {
            audioSource.PlayOneShot(incorrect);
            text.text = "µª¿ùÅo";
        }
    }
}
