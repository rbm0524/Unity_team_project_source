using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_helper : MonoBehaviour
{
    public Conversation_helper conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_helper>();
        string[] text = new string[] { "<������>\n(SpaceŰ�� ������~��簡 ����� �˰���~?)","<������>\n�ȳ�, ���� �� ������ �������� ���۹��� �˷��ִ� ���۾�\n(SpaceŰ�� ������~��簡 ����� �˰���~?)", "<������>\n �� ������ ����ǰ�� �����ϸ鼭 �߸��ϴ� �����̾�~", "<������>\n ���Ź� ������ 'F'Ű�� ������ ��~", "<������>\n ������ ���Ź��� Ȯ���ϴ� Ű�� 'I'Ű��~", "<������>\n �����̴� ���� W,A,S,DŰ�� �����̸� ��~", "<������>\n ������ ���콺�� ��������~", "<������>\n �� ��ȭ�⸦ ����� ��� ������ ���� �Ѹ��� �����ؾߵǴ� ������", "<������>\n �׷� �˾Ƽ� ���غ���"  };
        conversationScript.changeuitext(text);

    }

}


