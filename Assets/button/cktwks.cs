using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cktwks : MonoBehaviour//����
{
    public conversation conversationScript;
    public GameObject button;
    // Start is called before the first frame update
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "(��Ź���� ������ �ϳ� �ۿ� ������..)", "(�Ƴ� ȥ�� �������Ŷ� �����ߴµ�..)",
            "(�ٿ����� ���� ���� ���̴ٰ�..?)", "������ �ѷ��������� �� �ٸ� ������ �������� �ʾҴ�.",
            "<���ΰ�>\n �ٿ��� ��.. �Ⱦ��ϼ���?", "<�̴ٿ�>\n �ƴϿ�..?", "<���ΰ�>\n �ٿ���, ���� ƼŸ���� ���ٸ鼭��.",
            "<���ΰ�>\n �׷��� �� ��Ź���� ������ �ϳ��ۿ� ������?", "<�̴ٿ�>\n �ΰ����� ġ��� �ƴϿ���?",
            "<���ΰ�>\n ���� �Ƴ� ���� ���Ŀ� �� ���� �湮�� ���� �����.", "<���ΰ�>\n �׸��� �Ƴ��� ������ ã�� ���� ���� �ִ� ������ �״�� �ξ����.", "<�̴ٿ�>\n �׷� ��̰� ġ������.", "(���� �׷� �� �ִ�)"
            , " (������ �� ������ �츮 ��ȥ ������ �� �Ŷ� ��Ʈ�� ���� ���̶� ���̾�)", "(�Ƴ��� ġ������ ��򰡿� �־�� �ϴµ� �������� ����..)",
            "(�и� �ٿ����� ������ ���𰡸� ����� �ִ�)" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
