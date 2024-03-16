using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation_a : MonoBehaviour
{
    public Text uiText;
    string[] conversationarray;
    public GameObject conversationPanel;
    private float autoPlayDelay = 2.3f; // 대사 자동 재생 딜레이 시간

    private int currentTextIndex = 0; // 현재 대사 인덱스
    private bool isAutoPlaying = false; // 대사 자동 재생 중인지 여부

    private void Start()
    {
        uiText.text = "따르릉..! 따르릉..!";
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
