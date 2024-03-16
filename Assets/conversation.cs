using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conversation : MonoBehaviour
{
    public Text uiText;
    string[] conversationarray;
    public GameObject conversationPanel;
    public GameObject buttonParent1; // ���ο� ��ư�� ������ �θ� ������Ʈ
    public GameObject buttonParent2;
    public GameObject buttonParent3; // ���ο� ��ư�� ������ �θ� ������Ʈ
    bool button_act1;
    bool button_act2;
    bool button_act3;
    private void Start()
    {
         button_act1=false;
         button_act2= false;
         button_act3= false;
        //uiText.text = "ù ��° ��\n�� ��°";
        buttonParent1.gameObject.SetActive(false);
        buttonParent2.gameObject.SetActive(false);
        buttonParent3.gameObject.SetActive(false);
    }

    public void changeuitext(string[] text1)
    {
        if (uiText == null)
        {
            uiText = FindObjectOfType<Text>();
        }
        uiText.text = text1[0];
        conversationarray = text1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            buttonParent1.gameObject.SetActive(false);
            buttonParent2.gameObject.SetActive(false);
            buttonParent3.gameObject.SetActive(false);

            if (uiText.text == conversationarray[conversationarray.Length - 1]& button_act1 != true&button_act3 != true)
            {
                conversationPanel.SetActive(false);
            }
            for (int i = 0; i < conversationarray.Length - 1; i++)
            {
                if (uiText.text == conversationarray[i])
                {
                    uiText.text = conversationarray[i + 1];
                    break;
                }
            }
            if (uiText.text == "<���ΰ�>\n �̴ٿ����� ��� ���� �����غ���!")//�������� ����� ����
            {

                buttonParent1.gameObject.SetActive(true);
                button_act1 = true;
            }
            if (uiText.text == "<���ΰ�>\n �ٸ� �������� �����غ���!")//��ư���� ��� ��� �Ŀ� �ٽ� ���ư���
            {
                buttonParent1.gameObject.SetActive(true);
                button_act1 = true;
            }
            if (uiText.text == "<���ΰ�>\n ��� �� �̸�������..\n �� ������ ���λ���� ������ �̸��� �Ȱ���...")//�������� ����� ����
            {
                buttonParent3.gameObject.SetActive(true);
                button_act3 = true;

                //��ư Ȱ��ȭ
                //��ư���� ��� ��� �Ŀ� �ٽ� ���ư���
            }


            if (uiText.text == "(�и� �ٿ����� ������ ���𰡸� ����� �ִ�)")//�������� ����� ����
            {
                
                button_act1 = false;

                //��ư Ȱ��ȭ
                //��ư���� ��� ��� �Ŀ� �ٽ� ���ư���
            }
            if (uiText.text == " �ۿ� ������ �����..")//�������� ����� ����
            {

                button_act3 = false;

                //��ư Ȱ��ȭ
                //��ư���� ��� ��� �Ŀ� �ٽ� ���ư���
            }
            
        }
    }
}
