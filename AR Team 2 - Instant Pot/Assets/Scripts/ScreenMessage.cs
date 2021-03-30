using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenMessage : Singleton<ScreenMessage>
{
    public TextMeshProUGUI textLog;
    public TextMeshProUGUI textForTransform;

    private void Start()
    {
        textLog.text = "";
    }

    private void _log(string msg)
    {
        if(msg[0] != '\n')
        {
            msg = '\n' + msg;
        }

        textLog.text += msg;
        Debug.Log(msg);
    }

    private void _logForModelTransform(string msg)
    {
        if (msg[0] != '\n')
        {
            msg = '\n' + msg;
        }

        textForTransform.text = msg;
        Debug.Log(msg);
    }

    public static void Log(string msg)
    {
        Instance._log(msg);
    }

    public static void LogForModelTransform(string msg)
    {
        Instance._logForModelTransform(msg);
    }
}
