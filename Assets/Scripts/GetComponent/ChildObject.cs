using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildObject : MonoBehaviour
{
    private void Start()
    {
        GetComponentInParent<ParentObject>().DebugChildObject("child object");
    }

    public void ParentDebug(string content)
    {
        Debug.Log(content);
    }
}
