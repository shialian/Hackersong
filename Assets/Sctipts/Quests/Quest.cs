using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public int questNumber;
    public Option[] options;
    public Option answer;

    private void Start()
    {
        AssignQuestNumberToOptions();
    }

    private void AssignQuestNumberToOptions()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].questNumber = questNumber;
        }
    }
}
