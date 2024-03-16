using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Conversation_kill : MonoBehaviour
{
    public Text uiText;
    string[] conversationarray;
    public GameObject conversationPanel;
    private void Start()
    {
        //uiText.text = "<교수님>\n안녕, 나는 이 게임의 전반적인 조작법을 알려주는 헬퍼야\n(Space키를 눌러봐~대사가 진행돼 알겠지~?)";
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