using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zofflsej : MonoBehaviour//�޷�
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "<���ΰ�>\n �ٿ��� ��� ���� �� ��̶� ���� �Ŀ� ������ �� �־�����?", "<�̴ٿ�>\n �ƴϿ�.. �� �� ���ķ� ���� �������� �ʾҾ��", "<���ΰ�>\n �ٸ� �������� �����غ���!" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
