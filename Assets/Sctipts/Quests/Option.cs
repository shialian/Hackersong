using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public int questNumber = 0;

    private void OnMouseUpAsButton()
    {
        QuestBoard.Instance.AnswerCheck(questNumber, this);
    }
}
