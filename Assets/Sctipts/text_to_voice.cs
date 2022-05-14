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
        
        //ChatbotVoice.Speak("�ܦh��");
        ChatbotVoice.Speak("�p�j�A���ݧA��A�Aı�o����O�u���v�O�H");
        notice_obj.SetActive(true);
        Invoke("PlayerSpeak1", 1.0f);
        Invoke("ManySpeak_Part1_2", 2.5f);
    }

    public void PlayerSpeak1()
    {
        SpVoice PlayerVoice = new SpVoice();
        PlayerVoice.Voice = PlayerVoice.GetVoices().Item(0);
        PlayerVoice.Speak("���O����ӨӪ��a");
        notice_obj.SetActive(false);
    }

    public void ManySpeak_Part1_2()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);
        ChatbotVoice.Speak("�o�˰�...��ı�o���ä��u���O���~��W������A�ӬO�@�ؤߤ��ҦV�C");
    }
    public void ManySpeak_Part2()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);

        //ChatbotVoice.Speak("�ܦh��");
        ChatbotVoice.Speak("���O�o�ӪF����H���S�s�uٮ�����v�A�۶Ǧb��ڮɥN�A" +
            "���@�ӯ��A������Q�p���ͧl���A�y����������ʸ��B�~�ۤ��ΡC" +
            "���˥����������A�w���Y�ֻs���A�Q����ɶK�����N�n�C" +
            "�S�Q��v���Ӧ�ճܫ�S������A�ϭ��嬰�W�~�A�����A�ƭ��������C");
        ChatbotVoice.Speak("�u�n���H�o�{����,���H���z�X��I,�U���]���ܶ����a�C");
        notice_obj.SetActive(true);
        Invoke("PlayerSpeak2", 1.0f);
        Invoke("ManySpeak_Part2_2", 2.5f);

    }

    public void PlayerSpeak2()
    {
        SpVoice PlayerVoice = new SpVoice();
        PlayerVoice.Voice = PlayerVoice.GetVoices().Item(0);
        PlayerVoice.Speak("�ֶv���͡A������s�uٮ�����v���H");
        notice_obj.SetActive(false);
    }

    public void ManySpeak_Part2_2()
    {
        SpVoice ChatbotVoice = new SpVoice();
        ChatbotVoice.Voice = ChatbotVoice.GetVoices().Item(5);
        ChatbotVoice.Speak("�۶Ǩ��ӯ��A�^�h���ɦ��ơA���j�a���H���L�ؤj�j���A�λԫn�y�կ��L�uٮ���v�C");
        ChatbotVoice.Speak("�o���ܰ_�Ӱ��e�L��,�B���d��,�[�[����,�@���ڤߡC�A�O�H" +
            "�b�A�H�ͤ����~���L�����������ܡH�ոլݦb�o�̯d�U�A������a�I");
    }

}
