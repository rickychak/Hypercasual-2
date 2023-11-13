using System;
using UnityEngine;

public class AndroidLogger: ILogger
{
    private AndroidJavaClass _androidLogger;
    public AndroidLogger()
    {
        _androidLogger =  new AndroidJavaClass("android.util.Log");
    }

    public void Log(string message)
    {
        if (message.Length > 4000)
        {
            _androidLogger.CallStatic("e", "Unity-AndroidLogger", "Debug Message is too long, try using LogLongMessage instead.");
        }
        _androidLogger.CallStatic("v", "Unity-AndroidLogger", message);
    }

    public void LogWarning(string message)
    {
        _androidLogger.CallStatic("w", "Unity-AndroidLogger", message);
    }

    public void LogError(string message)
    {
        _androidLogger.CallStatic("e", "Unity-AndroidLogger", message);
    }

    public void LogLongMessage(string message)
    {
        
    }

    public void LogException(Exception exception)
    {
        _androidLogger.CallStatic("e", "Unity-AndroidLogger", exception.Message);
    }

    public void LogStacktrace(Exception exception)
    {
        _androidLogger.CallStatic("e", "Unity-AndroidLogger", exception.StackTrace);
    }
}
