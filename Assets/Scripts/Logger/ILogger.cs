using System;

public interface ILogger
{
    public void Log(string message);
    public void LogWarning(string message);
    public void LogError(string message);
    public void LogLongMessage(string message);
    public void LogException(Exception exception);
    public void LogStacktrace(Exception exception);
}
