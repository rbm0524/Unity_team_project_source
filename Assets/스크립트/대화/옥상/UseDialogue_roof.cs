using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_roof : MonoBehaviour
{
    public Conversation_roof conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_roof>();
        string[] text = new string[] { "(��---��)", "���� �ö�Դ�.", "������ ���ϰ� ������ ����. ", "���󿡴� �� ����ũ�� �����Ѵ�.", "(����...�� ����ũ�� ����Ҵ�.)",
                                        ".....","........","��..��̾�..","�ȿ��� �� ��ü�� �Ѽյ� ���·� �Ƴ��� ��ü�� �ִ�","���� �� ���� ������ ���� �� ���� �����´�.","���� � Į�� ���� �� ��ó�� ���δ�.",
                                        "������ ���� �ȾҴ� ��ó��.. ��� ���� �ʿ� ���� ����ִ�.","<���ΰ�>\n �Ƴ��� ���� ���� ���� �� ã�� ���ϰž�....","<���ΰ�>\n ���� ������ �Ű� �ؾ��� �� ����..",
                                        "(�� �ȿ� �� ��ȭ�Ⱑ �־��µ� �װ��� �̿��� ������ ��������)","('H'Ű�� ���� ������ ���ư���)"};
        conversationScript.changeuitext(text);

    }
}


