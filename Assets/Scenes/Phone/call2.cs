using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call2 : MonoBehaviour
{
    public GameObject calldlekdnjs;
    public GameObject phase2;
    public conversation conversationScript;
    public ExternalCanvasManager canvasManager;
    // Start is called before the first frame update
    public void callclick()
    {
        canvasManager = FindObjectOfType<ExternalCanvasManager>();
        phase2.SetActive(false);
        calldlekdnjs.SetActive(true);
        canvasManager.Activateconversation();
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[]
        {"<???>\n ��������?", "<���ΰ�>\n �ȳ��ϼ���. Ȥ�� ��̶�� ����� �ƽó���? ", "<???>\n ��...���� ���������δ� ������ ���� ������ �ƴұ� �ͳ׿�.", "<���ΰ�>\n �����̿�?", "<???>\n �� ���� �ù����Դϴ�.",
            "(���� �ù������״� ���̾��� �������� ������ \n�Ƴ��� �����븦 Ȯ���ϱ� ���� �ù��翡�� ������ �����Ͽ���.)", "<???>\n���� �׷� �� �� �����ִ� ��� ���� �ּҷ� �湮�ϰڽ��ϴ�.\n���� ������ ��� ���̰ŵ��.", "�����", "<���ΰ�>\n���ּż� �����մϴ�. �ٷ� �������� �Ѿ�ڸ� \n �� �� �Ƴ��� ������ �ֳ���?", "<�ù���>\n �� �Ƴ��� ȥ�� ��ô��󱸿�.", "<���ΰ�>\n �Ƴ��� ������ ���׾�����?", "<�ù���>\n���������� �����帮�� ����մϴ�.", "<���ΰ�>\n��.. �˰ڽ��ϴ�. ���ϰ� ��������.\n �ѿ��� ���� �ɾ� �����Կ�", "<�ù���>\n��.. �� �����մϴ�.", "�ʿ� �̸��� �����ִ� ����ȯ..", "<���ΰ�>\n ��� �� �̸�������..\n �� ������ ���λ���� ������ �̸��� �Ȱ���..." };//�ù��� ��ȭ
        conversationScript.changeuitext(text);

    }

}