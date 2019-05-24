
using UnityEngine;

public class Logger : MonoBehaviour
{
    /// <summary>
    /// Replace with another class that implements the ILogger interface
    /// </summary>
    private static ILogger _log = Debug.unityLogger;

    [Header("Logger Settings")]

    [SerializeField] private LogType _debugLogLevel;
    [SerializeField] private LogType _logLevel;

    void Start()
    {
        if (Debug.isDebugBuild)
            _log.filterLogType = LogType.Log;
        else
            _log.filterLogType = LogType.Warning;

        
    }


    public void LogError(GameObject sender, object message)
    {
        _log.LogError(sender.name, message, sender);
    }


}


//blink object on error / exception
//play sound on error / exception

