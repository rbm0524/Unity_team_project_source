using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_kill : MonoBehaviour
{
    public Conversation_kill conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_kill>();
        string[] text = new string[] { "<���ΰ�>\n ���� Ȥ�� �̸��� ���޾���� ���������..?","<�ù���>\n ....","<�ù���>\n �˼��մϴ� �� �̸��� Ư���ؼ� ������� ��� �ް� �߽��ϴ�.",
                                        "<�ù���>\n �׷��� ������ ���� �ʽ��ϴ�..","<���ΰ�>\n ����..ȯ�� �׷��� Ư���� �̸��ΰ���?","(�ù���� ���� ���� �����ϰ� �� �ڸ����� ������ �Ͼ ���� ���� ������)",
                                        "<���ΰ�>\n ....?","(�׷��� ��Ʋ�� ������. ���� �Ƴ��� ã�� ���ߴ�. �Ƴ��� ã�� ���� ������ ������ ��å�� ������)","ǫ...",
                                        "(�� ����..���� � ������ ������ ����� ���� ������� ��������.)","(�ù��翴��.. �ù���� �տ� ���� �Ǹ� ���� ä ��ǥ������ ���� �������� ����� ���� �־���.)",
                                        "<�ù���>\n �׷���..���� �������� �����ݾ�?","(�׷��� ���� �� ���� ������ �ǽ��� ������ �Ҿ���)" };
        conversationScript.changeuitext(text);

    }

}


