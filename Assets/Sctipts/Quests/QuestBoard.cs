using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestBoard : MonoBehaviour
{
    public static QuestBoard Instance { get; private set; }
    public Quest[] quests;

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
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Incorrect");
        }
    }
}
