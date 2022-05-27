using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public enum QuestType
{
    None,
    TriggerItem,
    QuestItem
}

public class Quest : MonoBehaviour
{
    public static Quest instance;
    public InteractableItem triggerItem;
    public InteractableItem[] questItems;
    public Text vrSubtitle;
    public bool questStart;
    [SerializeField]
    private string[] lines;
    private int itemFoundAmount;
    private int textIndex;
    public bool finish;

    public Animator fujunAnim;

    public AudioClip[] clips;

    private void Start()
    {
        instance = this;
        textIndex = -1;
        finish = false;
        GetQuestTexts();
        InitializeItems();
    }

    private void GetQuestTexts()
    {
        StreamReader reader = new StreamReader("Assets/Texts/Quest.txt");
        string text = reader.ReadToEnd();
        lines = text.Split('\n');
    }

    private void Update()
    {
        if(questStart && OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            textIndex++;
            if (finish)
            {
                textIndex = Mathf.Min(textIndex, 5);
                Dialogue.instance.PlayClip(clips[textIndex]);
            }
            else
            {
                textIndex = Mathf.Min(2, textIndex);
                Dialogue.instance.PlayClip(clips[textIndex]);
                if(textIndex == 2)
                {
                    fujunAnim.SetTrigger("Quest Start");
                }
            }
            vrSubtitle.text = lines[textIndex];
            if (textIndex == 5)
            {
                questStart = false;
            }
        }
    }

    private void InitializeItems()
    {
        triggerItem.questType = QuestType.TriggerItem;
        for (int i = 0; i < questItems.Length; i++)
        {
            questItems[i].gameObject.SetActive(false);
            questItems[i].questType = QuestType.QuestItem;
        }
    }

    public void QuestStart()
    {
        questStart = true;
        for (int i = 0; i < questItems.Length; i++)
        {
            questItems[i].gameObject.SetActive(true);
            questItems[i].enabled = true;
        }
        itemFoundAmount = 0;
        InteractionItemManager.instance.ResetInroductions();
    }

    public void ItemFound()
    {
        itemFoundAmount++;
        textIndex++;
        Dialogue.instance.PlayClip(clips[textIndex]);
        vrSubtitle.text = lines[textIndex];
        if(itemFoundAmount == questItems.Length)
        {
            finish = true;
            fujunAnim.SetTrigger("Quest End");
        }
    }
}
