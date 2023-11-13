using System;
public class IOSLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }

    public void LogWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();
        
    }

    public void LogError(string message)
    {
        Console.Error.WriteLine(message);
    }

    public void LogLongMessage(string message)
    {
        
    }

    public void LogException(Exception exception)
    {
        Console.Error.WriteLine(exception.Message);
    }

    public void LogStacktrace(Exception exception)
    {
        Console.Error.WriteLine(exception.StackTrace);
    }
}