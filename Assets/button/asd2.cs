using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd2 : MonoBehaviour
{
    public conversation conversationScript;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "asd" };
        conversationScript.changeuitext(text);
    }
}
