using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{
    public conversation conversationScript;
    public GameObject button;
    // Start is called before the first frame update
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "<���ΰ�>\n �ٿ��� �ñ��Ѱ� �ִµ���.. TV�� �������� �����ִ��� Ȥ�� �ƽó���?", "<�̴ٿ�>\n �ƴϿ� �װ� �� �𸣰ھ��..", "<���ΰ�>\n �ٸ� �������� �����غ���!" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
