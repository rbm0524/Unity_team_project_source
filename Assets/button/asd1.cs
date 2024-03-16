using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd1 : MonoBehaviour
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "asd" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
