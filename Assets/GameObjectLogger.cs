
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GameObjectLogger : MonoBehaviour {

    [Header("GameObjectLogger Settings")]

    public bool LoggingEnabled;
    public bool Bold;
    public Color Color;
    public bool ShowGizmo;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Draws a Sphere Gizmo if enabled
    /// </summary>
    private void OnDrawGizmos()
    {
        if(ShowGizmo)
        {
            Gizmos.color = Color;
            Gizmos.DrawSphere(transform.position, 1);
        }
 
    }



    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <param name="message"></param>
    /// <param name="args"></param>
    public void LogError(string message, params object[] args)
    {
        UnityEngine.Debug.Log(string.Format(message, args), gameObject);
    }

}
