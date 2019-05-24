
/// TestObject

using UnityEngine;
using Cawtcha.Patterns; // add using statement

// Change from MonoBehaviour to BaseBehavior
public class TestScript : BaseBehavior 
{



	// Use this for initialization
	void Start ()
    {
        LogInfo("Start has been called.");
        LogWarn("Still starting...");
        LogError("An error happened... not really.");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
