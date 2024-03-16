using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue : MonoBehaviour
{
    public Conversation_a conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_a>();
        string[] text = new string[] { "������..! ������..!", "�˶��Ҹ��� �鸰��.", "<���ΰ�>\n ��...","�� ������ ���� �� �� ����.","����� ����ϰ� �Ӹ��� ���� �� ������.","���� ��� ���������� �������� ������ �� ����.","���� ���� ſ �ΰ�","�Ҿ��� ������ ������ �Ϸ� ��Ʋ�� �ƴ� �Ͷ� �״�� ���� �޴����� �״�.","<���ΰ�>\n 5�� 21��..","<���ΰ�>\n ������ �� �Ƴ��� ������ ì�����..?","<���ΰ�>\n ���� �� ���� ���� ���� ���µ�..","<���ΰ�>\n �ƴ� �׺��� ���� �����ϰ� ������ �ϱ� �߾���..","���ڱ� �Ҿ��ϴ�..","�Ƴ����� ��ȭ�� �ɾ��..","(������ �����־�.. ���� �缭����..)","<���ΰ�>\n ��...","<���ΰ�>\n�ȵǰڴ�.. ���� ã�ư�����","....","��-��","<���ΰ�>\n ��� ������...?","������..","<���ΰ�>\n ��̾�...?","<���ΰ�>\n�ƹ��� ����.."  };
        conversationScript.changeuitext(text);

    }
}


