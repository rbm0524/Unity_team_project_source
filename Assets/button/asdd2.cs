using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdd2 : MonoBehaviour
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public Item Ruminol;
    public GameObject inventorycanvas;
    private Inventory inventory;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "<���ΰ�>\n ...","<���ΰ�>\n �׷� �� �� TV�� �������ְ� �ٷ� ���̾�����??","<�ù���>\n �� �½��ϴ�.","<���ΰ�>\n �Ʊ� �׳� ������ǰ�̶�� �ϼ̴µ� TV�� �³����׿�..?","<�ù���>\n ...","<�ù���>\n ��.. ���Բ� �ù踦 �����ص帮�� ���� �ٷ� �����ϴ�.","(���� �̻��ϴ�.. ���� �ƹ��� ���� �͵� �ƴϰ�..)","(���ſ� TV�� �׳� �ΰ� ���� ���� ����..)","<���ΰ�>\n ���� ��������� ���� TV�� �� �� ���� ������ ���� ���� �ֽ��ϴ�.","<�ù���>\n ������.. ���� �ڶ� �𸣰ڽ��ϴ�..","<�ù���>\n ������ ����... ���� ������ ȭ�� ���� ���̳׿�..","<�ù���>\n ������ �����ž� �� �� �����ϴ�..","(�ù��簡 ���� ������.)","<���ΰ�>\n �̰� �ܼ��� �Ƴ��� ����� ���� �³�..?","<���ΰ�>\n �Ʊ� ���� ���� ���ǿ� �̻��� �������� ���Ҿ�..","<���ΰ�>\n ��̳� ����� �Ѹ��� ���ڱ��� ���´ٴµ�.."," �ۿ� ������ �����.." };
        conversationScript.changeuitext(text);

        inventory = FindObjectOfType<Inventory>();
        inventory.AddItem(Ruminol);

        button.SetActive(false);
    }
}
