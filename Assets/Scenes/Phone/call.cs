using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call : MonoBehaviour
{
    public GameObject calldlekdnjs;
    public GameObject phase2;
    public GameObject bottun1;
    public GameObject bottun2;
    public conversation conversationScript;
    public ExternalCanvasManager canvasManager;
    // Start is called before the first frame update
    public void callclick()
    {
        canvasManager = FindObjectOfType<ExternalCanvasManager>();
        bottun1.SetActive(false);
        bottun2.SetActive(false);
        phase2.SetActive(false);
        calldlekdnjs.SetActive(true);
        canvasManager.Activateconversation();
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[]
        { "�켱 �ٿ� ������ ��ȭ�� �غ��� �� �� ����..", "<�̴ٿ�>\n ��������?" ,"<���ΰ�>\n�ٿ��� �������̿���. �� �����̾��?","<�̴ٿ�>\n �� �ΰ���! �ٵ�... ���� ���̿���?","�ٿ� ���� ��Ҹ����� �Ҿ����� ��������.","<���ΰ�>\n �ٸ��� �ƴϰ� ����� �� �ִµ�..","<���ΰ�>\n Ȥ�� ���� �� 5�� 14�� \n��� ���Ͽ� ���� �����̳���??","<�̴ٿ�>\n ....","<���ΰ�>\n ��̰�...�ٿ����� ���� �� ���ķ� ������ �ȵſ�.","<���ΰ�>\n �޴����� ���� ���� ��� ������ �𸣰ھ��...","<�̴ٿ�>\n ...","<�̴ٿ�>\n ��.. �� �� ��̶� ������ ���� ���̾��..","<�̴ٿ�>\n �� �� ��̰� �� �� �� �뿡 �Բ� ������ ���ٰ� �߰ŵ��..","<�̴ٿ�>\n ���� ������ΰ� �ͱ⵵ �ϰ�..","<�̴ٿ�>\n .....","<�̴ٿ�>\n �ΰ���..",
            "<�̴ٿ�>\n �� ��� ��� ���� ����� ���������?","(�����)","��-��","�������� �︰��.","<���ΰ�>\n �ٿ��� �������.","<�̴ٿ�>\n��.. �ΰ��� ���� ���� ����������?","<�̴ٿ�>\n ���� ���� ����� �ϼ��ݾƿ�.. �͸� ���Ƶ� �Ҹ��� �鸰�ٰ�..","��!!","�̴ٿ��� ���� �̲��������� �ڵ����� �ٴڿ� ����߷ȴ�.","<�̴ٿ�>\n ��.. ������ �� ������.","<���ΰ�>\n ��ø� �ɾ� �輼��.. ���ǰŶ� �帱�Կ�.","<���ΰ�>\n ��..?","�ξ����� ���� ��ȭ���� ���..","<���ΰ�>\n �̴ٿ����� ��� ���� �����غ���!" };
        conversationScript.changeuitext(text);

    }

}