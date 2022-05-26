using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoices : MonoBehaviour
{
    public AudioClip voice1;
    public AudioClip voice2;
    public AudioClip voice3;
    public AudioClip voice4;
    public AudioClip voice5;
    public AudioClip voice6;
    public AudioClip voice7;
    public AudioClip voice8;
    public AudioClip voice9;
    public AudioClip voice10;
    public AudioClip voice11;
    public AudioClip voice12;

    AudioSource audioSource;
    public GameObject chatframe;
    public GameObject button1_1;
    public GameObject button1_2;
    public GameObject button2_1;
    public GameObject button2_2;
    public GameObject button3;
    public GameObject button4_1;
    public GameObject button4_2;
    public GameObject button5;
    public GameObject blackboard;
    public GameObject commentboard;

    private float timer;
    public GameObject StateTarget;
    public GameObject ActionBook;
    private Animator animator;
   

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = StateTarget.GetComponent<Animator>();
    }
    public void StateTo5()
    {
        animator.SetInteger("State", 5);
    }
    public void StateTo1()
    {
        animator.SetInteger("State", 1);
    }
    public void StateTo2()
    {
        animator.SetInteger("State", 2);
    }
    public void PlayVoice1()
    {
        animator.SetInteger("State", 1);
        audioSource.PlayOneShot(voice1);
        timer = voice1.length;
        Invoke("ShowButton1", timer);
    }
    public void ShowButton1()
    {
        animator.SetInteger("State", 2);
        button1_1.SetActive(true);
        button1_2.SetActive(true);
    }
    public void PlayVoice2()
    {
        animator.SetInteger("State", 1);
        audioSource.PlayOneShot(voice2);
        timer = voice2.length;
        Invoke("StateTo2", timer);
    }
    
    public void PlayVoice3()
    {
        //ActionBook.SetActive(true);
        animator.SetInteger("State", 4);
        Invoke("StateTo5", 1.1f);
        audioSource.PlayOneShot(voice3);
        timer = voice3.length;
        Invoke("ShowButton2", timer);
    }
    public void ShowButton2()
    {
        //animator.SetInteger("State", 2);
        animator.SetInteger("State", 6);
        button2_1.SetActive(true);
        button2_2.SetActive(true);
    }
    public void PlayVoice4()
    {
        //animator.SetInteger("State", 1);
        animator.SetInteger("State", 4);
        Invoke("StateTo5", 1.1f);
        audioSource.PlayOneShot(voice4);
        timer = voice4.length;
        Invoke("PlayVoice5", timer);
    }
    public void PlayVoice5()
    {
        //animator.SetInteger("State", 2);
        animator.SetInteger("State", 6);
        chatframe.SetActive(true);
        audioSource.PlayOneShot(voice5);
        timer = voice5.length;
        Invoke("PlayVoice6", timer);
    }
    public void PlayVoice6()
    {
        //animator.SetInteger("State", 1);
        animator.SetInteger("State", 4);
        Invoke("StateTo5", 1.1f);
        chatframe.SetActive(false);
        audioSource.PlayOneShot(voice6);
        timer = voice6.length;
        Invoke("ShowButton3", timer);
    }
    public void ShowButton3()
    {
        //animator.SetInteger("State", 2);
        animator.SetInteger("State", 6);
        button3.SetActive(true);
    }
    public void PlayVoice7()
    {
        //ActionBook.SetActive(false);
        animator.SetInteger("State", 1);
        audioSource.PlayOneShot(voice7);
        timer = voice7.length;
        Invoke("PlayVoice8", timer);
    }
    public void PlayVoice8()
    {
        animator.SetInteger("State", 2);
        audioSource.PlayOneShot(voice8);
        timer = voice8.length;
        Invoke("StateTo1", 0.5f);
        Invoke("PlayVoice9", timer);
    }
    public void PlayVoice9()
    {
        animator.SetInteger("State", 2);
        chatframe.SetActive(true);
        audioSource.PlayOneShot(voice9);
        timer = voice9.length;
        Invoke("PlayVoice10", timer);
    }
    public void PlayVoice10()
    {
        animator.SetInteger("State", 1);
        chatframe.SetActive(false);
        audioSource.PlayOneShot(voice10);
        timer = voice10.length;
        Invoke("PlayVoice11", timer);
    }
    public void PlayVoice11()
    {
        animator.SetInteger("State", 2);
        audioSource.PlayOneShot(voice11);
        timer = voice11.length;
        Invoke("StateTo1", 0.5f);
        Invoke("ShowButton4", timer);
    }
    public void ShowButton4()
    {
        animator.SetInteger("State", 2);
        button4_1.SetActive(true);
        button4_2.SetActive(true);
    }
    public void PlayVoice12()
    {
        //animator.SetInteger("State", 1);
        //animator.SetInteger("State", 2);
        animator.SetInteger("State", 3);
        audioSource.PlayOneShot(voice12);
        timer = voice12.length;
        Invoke("ShowCommentBoard", timer);
    }
    public void ShowCommentBoard()
    {
        commentboard.SetActive(true);
        blackboard.SetActive(true);
        button5.SetActive(true);
    }
}
