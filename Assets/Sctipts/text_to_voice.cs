using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeechLib;


public class text_to_voice : MonoBehaviour
{
    public string sentence;
    public float delay_time = 0;
    public GameObject notice_obj;

    public void InvokeSpeak()
    {
        Invoke("Speak", delay_time);
    }
    public void Speak()
    {
        SpVoice voice = new SpVoice();
        voice.Voice = voice.GetVoices().Item(3);
        voice.Speak(sentence);
    }

    public void InvokeManySpeak_Part1()
    {
        Invoke("ManySpeak_Part1_1", delay_time);
    }
    public void InvokeManySpeak_Part2()
    {
        Invoke("ManySpeak_Part2", delay_time);
    }
    public void ManySpeak_Part1_1()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);
        
        //ChatbotVoice.Speak("很多話");
        ChatbotVoice.Speak("小姐，那問你喔，你覺得什麼是「美」呢？");
        notice_obj.SetActive(true);
        Invoke("PlayerSpeak1", 1.0f);
        Invoke("ManySpeak_Part1_2", 2.5f);
    }

    public void PlayerSpeak1()
    {
        SpVoice PlayerVoice = new SpVoice();
        PlayerVoice.Voice = PlayerVoice.GetVoices().Item(0);
        PlayerVoice.Speak("美是比較而來的吧");
        notice_obj.SetActive(false);
    }

    public void ManySpeak_Part1_2()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);
        ChatbotVoice.Speak("這樣啊...我覺得美並不真的是指外表上的美醜，而是一種心之所向。");
    }
    public void ManySpeak_Part2()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);

        //ChatbotVoice.Speak("很多話");
        ChatbotVoice.Speak("像是這個東方美人茶又叫「椪風茶」，相傳在日據時代，" +
            "有一個茶農的茶園被小綠葉蟬吸食，造成茶葉卷芯缺葉、品相不佳。" +
            "不捨丟棄茶葉的茶農硬著頭皮製茶，想說能補貼成本就好。" +
            "沒想到洋茶商行試喝後沒有嫌棄，反倒驚為上品，給茶農數倍的茶價。");
        ChatbotVoice.Speak("只要有人發現賞識,情人眼理出西施,垃圾也能變黃金吧。");
        notice_obj.SetActive(true);
        Invoke("PlayerSpeak2", 1.0f);
        Invoke("ManySpeak_Part2_2", 2.5f);

    }

    public void PlayerSpeak2()
    {
        SpVoice PlayerVoice = new SpVoice();
        PlayerVoice.Voice = PlayerVoice.GetVoices().Item(0);
        PlayerVoice.Speak("福鈞先生，為什麼叫「椪風茶」阿？");
        notice_obj.SetActive(false);
    }

    public void ManySpeak_Part2_2()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);
        ChatbotVoice.Speak("相傳那個茶農回去分享此事，但大家都以為他誇大吹牛，用閩南語譏笑他「椪風」。");
        ChatbotVoice.Speak("這茶喝起來高蜜馥郁,唇齒留香,久久不散,一見芳心。你呢？" +
            "在你人生中有品嘗過類似的滋味嗎？試試看在這裡留下你的痕跡吧！");
    }

}
