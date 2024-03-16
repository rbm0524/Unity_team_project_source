using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Conversation_roof : MonoBehaviour
{
    public Text uiText;
    string[] conversationarray;
    public GameObject conversationPanel;
    private void Start()
    {
        uiText.text = "(≥¢---¿Õ)";
    }

    public void changeuitext(string[] text1)
    {
        if (uiText == null)
        {
            uiText = FindObjectOfType<Text>();
        }
        uiText.text = text1[0];
        Debug.Log(uiText.text);
        conversationarray = text1;
        Debug.Log(uiText.text);

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (uiText.text == conversationarray[conversationarray.Length - 1])
            {
                conversationPanel.SetActive(false);
            }
            for (int i = 0; i < conversationarray.Length - 1; i++)
            {
                if (uiText.text == conversationarray[i])
                {
                    uiText.text = conversationarray[i + 1];
                    break;
                }
            }

        }
    }
}
