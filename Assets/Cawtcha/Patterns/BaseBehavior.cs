
using UnityEngine;
using Cawtcha.Diagnostics;

namespace Cawtcha.Patterns
{
    /// <summary>
    /// Base class for all game objects
    /// </summary>
	public abstract class BaseBehavior : MonoBehaviour 
	{
        [Header("Logging")]
        [SerializeField] Colors _logColor = Colors.black;
        [SerializeField] bool _logEnabled = false;
        [SerializeField] bool _showGizmoIcon = false;
     
        protected void LogError(string message)
        {
            Log.Error(this, message.Colored(_logColor));
        }

        protected void LogError(string message, params object[] args)
        {
           Log.Error(this, message.Colored(_logColor), args);
        }

        protected void LogWarn(string message)
        {
            if (_logEnabled) Log.Warn(this, message.Colored(_logColor));
        }

        protected void LogWarn(string message, params object[] args)
        {
            if (_logEnabled) Log.Warn(this, message.Colored(_logColor), args);
        }

        protected void LogInfo(string message)
        {
            if (_logEnabled) Log.Info(this, message.Colored(_logColor));
        }

        protected void LogInfo(string message, params object[] args)
        {
            if (_logEnabled) Log.Info(this, message.Colored(_logColor), args);
        }

        private void OnDrawGizmos()
        {
            if(_showGizmoIcon) Gizmos.DrawIcon(transform.position, string.Empty, true);
        }
    }
}

