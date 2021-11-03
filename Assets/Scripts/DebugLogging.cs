using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogging : MonoBehaviour
{
    public bool debug = false;
    public void EnableDebug(bool isEnabled)
    {
        debug = isEnabled;
    }
    public void Log(string message)
    {
        if (debug == false)
            return;
        Debug.Log(this.gameObject.name = ": " + message);
    }
    public void Warning(string message)
    {
        if(debug == false)
            return;
        Debug.LogWarning(this.gameObject.name = ": " + message);
    }
    public void Error(string message)
    {
        if(debug == false)
            return;
        Debug.LogError(this.gameObject.name = ": " + message);
    }
}
