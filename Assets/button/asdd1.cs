using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class asdd1 : MonoBehaviour//�̸��� �����.
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        SceneManager.LoadScene("kill");
        //string[] text = new string[] { "<���ΰ�>\n ���� Ȥ�� �̸��� ���޾���� ���������..?", "<�ù���>\n ....", "<�ù���>\n �˼��մϴ� �� �̸��� Ư���ؼ� ������� ��� �ް� �߽��ϴ�.", "<�ù���>\n �׷��� ������ ���� �ʽ��ϴ�..", "<���ΰ�>\n ����..ȯ�� �׷��� Ư���� �̸��ΰ���?", "(�ù���� ���� ���� �����ϰ� �� �ڸ����� ������ �Ͼ ���� ���� ������)", "<���ΰ�>\n ....?", "(�׷��� ��Ʋ�� ������. ���� �Ƴ��� ã�� ���ߴ�. �Ƴ��� ã�� ���� ������ ������ ��å�� ������)", "ǫ...", "(�� ����..���� � ������ ������ ����� ���� ������� ��������.)", "(�ù��翴��.. �ù���� �տ� ���� �Ǹ� ���� ä ��ǥ������ ���� �������� ����� ���� �־���.)", "<�ù���>\n �׷���..���� �������� �����ݾ�?", "(�׷��� ���� �� ���� ������ �ǽ��� ������ �Ҿ���)" };
        //conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
