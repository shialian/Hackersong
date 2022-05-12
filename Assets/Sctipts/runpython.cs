using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class runpython : MonoBehaviour
{

    // Update is called once per frame
    private void Start()
    {
        RunPythonScript("-u");
    }
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        //string[] arr = new string[2];
    //        //arr[0] = "10";
    //        //arr[1] = "20";
    //        //RunPythonScript(arr);
    //        RunPythonScript("-u");
    //    }
    //}
    // private static void RunPythonScript(string[] argvs)
    private static void RunPythonScript(string args = "")
    {
        Process p = new Process();
        string path = @"D:\lon08\桌面\作業\四下\文化黑客松\voice_to_word.py";
        //string path = @"D:\lon08\桌面\作業\四下\文化黑客松\123.py";
        //foreach (string temp in argvs)
        //{
        //    path += " " + temp;
        //}
        p.StartInfo.FileName = @"C:\Users\lon08\anaconda3\envs\chatbot\python.exe";

        p.StartInfo.UseShellExecute = false;
        p.StartInfo.Arguments = path;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.RedirectStandardInput = true;
        p.StartInfo.CreateNoWindow = true;

        p.Start();
        p.BeginOutputReadLine();
        p.OutputDataReceived += new DataReceivedEventHandler(Get_data);
        p.WaitForExit();
    }
    private static void Get_data(object sender, DataReceivedEventArgs eventArgs)
    {
        if (!string.IsNullOrEmpty(eventArgs.Data))
        {
            print("你好");
            print(eventArgs.Data);
        }
        
    }
}
