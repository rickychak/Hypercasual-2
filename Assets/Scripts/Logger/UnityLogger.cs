using System;
using UnityEngine;
public class UnityLogger: ILogger
{
    public void Log(string message)
    {
        if (message.Length > 4000) return;
        Debug.Log(message);
    }

    public void LogWarning(string message)
    {
        Debug.LogWarning(message);
    }

    public void LogError(string message)
    {
        Debug.LogError(message);
    }

    public void LogException(Exception ex)
    {
        Debug.LogError(ex.Message);
    }

    public void LogStacktrace(Exception ex)
    {
        Debug.LogError(ex.StackTrace);
    }

    public void LogLongMessage(string message)
    {
        
    }
}
