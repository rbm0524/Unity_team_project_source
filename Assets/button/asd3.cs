using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd3 : MonoBehaviour
{
    public conversation conversationScript;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "asd" };
        conversationScript.changeuitext(text);
    }
}
