using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_police : MonoBehaviour
{
    public Conversation_police conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_police>();
        string[] text = new string[] { "<����>\n ��.. �Ű� ���� �ƽ��ϴ�.","<����>\n  Ư������ ������� Ÿ���� ���ɼ��� �����ϴ�.",
                                        "<����>\n �켱 ���縦 �����ϰڽ��ϴ�.","������ �߰����� ������ ã�Ƴ´�.","���� : ��ȥ ������ �� �����̴�.�̴ٿ��� ������ ������ �����ִ�.",
                                        "TV����: ����ȯ�� �����̾���.","ī��Ʈ ���� �κ�: ������ �м��غ��� �󺥴� Ƽ�� û�갡���� ���� ��ü�� ���� ���̾���.","�Ƴ��� ��ü: ������ �ξ�Į�� ���� ���������̴�.",
                                        "�� ���� �κп� Į�� �� ������ �ִ�.","�Ƴ��� �ʿ��� û�갡���� �� �󺥴� Ƽ�� �����ִ�.","������ �����ϱ�?"};
        conversationScript.changeuitext(text);

    }

}


