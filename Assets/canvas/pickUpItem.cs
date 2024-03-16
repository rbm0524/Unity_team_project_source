using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickUpItem : MonoBehaviour
{
    public TextMeshProUGUI Text; // Text ������Ʈ ������ ���� public ����
    public GameObject a;
    private Inventory inventory;
    public Item Phone;
    public Item Calender;
    public Item Charger;
    public Item Computer;
    public Item Diary;
    public Item Key;
    public Item Medicalrecord;
    public Item Ruminol;
    public Item Teacup;
    public Item Uncharged;
    public GameObject inventorycanvas;
    public Item Post_it;
    string[] textall = null;

    public void print()
    {
          string objectName = Player.collidedObjectName; // collidedObjectName ������ ���� ������
          if(objectName == "TV")
          {
              if (Text == null)
              {
                    Text = FindObjectOfType<TextMeshProUGUI>();
              }

              string[] text = new string[] { "ó�� ���� TV�̴�.", "�� �� ���� �������� �� ���� �����ִ�." };
              textall = text;
              Text.text = textall[0];
          }

        if (objectName == "stain")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "ī��Ʈ : ī��Ʈ�� ���������� ������ �ִ�", "ī��Ʈ ��� : � ��ü�� ���� �������� �κ��� �ִ�." };
            textall = text;
            Text.text = textall[0];
        }

        if (objectName == "Table")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "���� �ϳ��� ������ �ִ�.", "������ �׿��ִ�."};
            textall = text;
            Text.text = textall[0];
        }

        if (objectName == "VintageTelephone")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "������ �Ű��ߴ�." };
            textall = text;
            Text.text = textall[0];

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; // ���콺 Ŀ���� ���̰�
            SceneManager.LoadScene("Telephone"); // sceneToLoad�� ����� ������ ��ȯ

        }

        if (objectName == "Trashcan")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "���� 30�� ���� ������ �ִ�." };
            textall = text;
            Text.text = textall[0];

        }

        if (objectName == "��̳� 1")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "(�Ƴ��� �޴������� �ڱ⿡�� ��ȭ�� �Ǵ�.)", "(��ư 1���� ���� ����Ǿ� �ֱ���..)","�Ƿ� ���� ī��Ʈ�� �������� ���� ���ڱ� �Ӹ��� ������.","�߾�Ÿ��� �Ҹ��� �鸰��..","���� �� �׷����µ�.. ���ڱ� ������ �� ����..","���ڱ� �������� �Ƴ��� �Ȱ� �ִ� ����� ���ö���.. �ϳ� ���� �Ȱ� �ִ� �� ����..","�Ƴ��� ���� ���� �� �� ������ ���� ��� ���� �þ�߸��� �ִ�.","...","�� �߾�Ÿ��� �Ҹ��� �鸰��.","���ڱ� �������� �Ƴ��� ���ĸް� �������� ���ϴ� ����� ���ö���..","����,. ���� ������ �� �� ����.", "���� ���� �������� ������"};
            textall = text;
            Text.text = textall[0];

        }

        if (objectName == "Medicine")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "��Ȯ�� 30�� ���� ���� ����ִ�.", "�������뿡 �ִ� ��� ���� �� ����." };
            textall = text;
            Text.text = textall[0];
        }

        if (objectName == "Computer")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "�ǽð� �˻��� : ���� ������ ����ȯ, 5�� �� ���..", "û�갡��.. �Ƹ�� ������ ����.." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Computer);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Phone")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "�Ƴ��� �޴����̴�.", "���͸��� �����ϴ�.." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Uncharged);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Supplementary battery")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "����� �������͸��̴�." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Charger);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Medical records")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "���� �����Ϻ� ����..", "�Ƴ��� ���Ϸκ��� 30�� �ڿ� �� ó���� ������." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Medicalrecord);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Post-it")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "�� ���� ���ϰ� ������ ������ �Ҹ��� �鸰��.", "(���������---�� ��)", "???: ��! �ʳ� ������ �϶�� ����\n �ѵ��� �����ϴ��� �� �׷���?",
                "���� �� �� �� �ò����� �ϸ� ���δٰ� ����?\n �� ���� �����̴�.������!!", "(���� ���� ������ �ű⿡�� �Ƴ��� �Ʒ����� ��� �ִ� ���ȱ��� ���־���.)", "���ȱ��� �ٿ����� ������ �����״�.", "���ȱ�: ��.. ������ ������ �ͼ� �ò����� �ϴ��� ���õ� �ͼ� �Ȱ��� �ò����� �ϳ�!", "���ȱ�: �׶��� ����Ʈ������ ����ߴµ�..!", "���ȱ�: ������ ��¥ �� ���ھ�!", "���ΰ�: (�� ��ħ�� ã�� ����Ʈ���� �� ����� �� ���̱���)","(����Ʈ�տ��� ���� �������� ��Ʈ������ �ް� �ִٴ� ���� �Բ� ���� ������ ������ ����־���.)", "(���� �� ���� �� �� ���� ������ ��� �ִٰ� ����µ� �� ����� �� ����ΰ� ����.) ���� �η����� ���� ���ȱ����� ������.)", "���ΰ�: ������ ������ ��� �ߴµ� �׶��� ��Ȯ�� �����ϱ�?", "���ȱ�: ������ ���̶�� ���ݾ�XX!", "���ΰ�: (������ ���̸� �ٿ����� �湮�� ��¥ �׸��� �Ƴ��� �������� ���� ��¥�� �����ϴ�."};
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Post_it);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Calender")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "5���� ������ �޷��̴�.", "5�� 14�� �� ������ ���� �� ����." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Calender);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Kitchen Knife")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "�ϳ� ��ī�ο� �ξ�Į�̴�.." };
            textall = text;
            Text.text = textall[0];
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //false�� �ٲ� �ʿ�x
        {
            try
            {
                if (Text.text == textall[textall.Length - 1])
                {
                    a.SetActive(false);
                    //Text.text�� null�� �س��� ������ �ִ°�
                }
                else
                {
                    for (int i = 0; i < textall.Length - 1; i++)
                    {
                        if (textall[i] == Text.text)
                        {
                            Text.text = textall[i + 1];
                            break;
                        }
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                // ���ܸ� �����ϰ� �Ѿ
            }
        }
    }
}