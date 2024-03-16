using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation_a : MonoBehaviour
{
    public Text uiText;
    string[] conversationarray;
    public GameObject conversationPanel;
    private float autoPlayDelay = 2.3f; // ��� �ڵ� ��� ������ �ð�

    private int currentTextIndex = 0; // ���� ��� �ε���
    private bool isAutoPlaying = false; // ��� �ڵ� ��� ������ ����

    private void Start()
    {
        uiText.text = "������..! ������..!";
    }

    public void changeuitext(string[] text1)
    {
        if (uiText == null)
        {
            uiText = FindObjectOfType<Text>();
        }
        uiText.text = text1[0];
        conversationarray = text1;
        StartCoroutine(AutoPlayConversation());
    }

    private IEnumerator AutoPlayConversation()
    {
        isAutoPlaying = true;
        yield return new WaitForSeconds(autoPlayDelay);

        while (currentTextIndex < conversationarray.Length - 1)
        {
            currentTextIndex++;
            uiText.text = conversationarray[currentTextIndex];
            yield return new WaitForSeconds(autoPlayDelay);
        }

        isAutoPlaying = false;
        conversationPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isAutoPlaying)
            {
                NextConversation();
            }
        }
    }

    private void NextConversation()
    {
        if (currentTextIndex < conversationarray.Length - 1)
        {
            currentTextIndex++;
            uiText.text = conversationarray[currentTextIndex];
        }
        else
        {
            conversationPanel.SetActive(false);
        }
    }
}
