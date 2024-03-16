using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Use : MonoBehaviour
{
    private Inventory inventory;//�κ��丮�Լ�
    public conversation conversationScript;
    public Slot slot;
    public Item UnChared;
    public Item Phone;
    public Item Charger;
    public Transform usebutton; // ��ư
    public Transform throwbutton;//��ư
    public ExternalCanvasManager canvasManager; //�ܺ� ĵ������ ������ �ν��Ͻ�
    //��̳�
    public GameObject ruminol_active1;//�ξ�Į
    public GameObject ruminol_active2; //�Ž� �ٴ�
    public GameObject ruminol_active3;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void onclick()
    {
        canvasManager = FindObjectOfType<ExternalCanvasManager>();//�ܺ� ĵ���� �ν��Ͻ� �Ҵ�
        Item slotitem = slot.GetItem();
        inventory = FindObjectOfType<Inventory>();//�κ��丮���� ��ü ��ȯ 
        //������� use ��ư Ŭ���ÿ� �ൿ�� �̹�Ʈ
        if (slotitem.itemName == "Phone")//������ �ڵ���
        {
            Debug.Log("phone");
            canvasManager.ActivatePhone();

        }//�ڵ���
        if (slotitem.itemName == "Calender")
        {
            canvasManager.ActivateCanlender();
            Debug.Log("Calender");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "5���� ������ �޷��̴�.", "5�� 14�� �� ������ ���� �� ����." };
            conversationScript.changeuitext(text);

        }//Ķ����
        if (slotitem.itemName == "Charger")//�ڵ��� ����
        {
            Debug.Log(inventory.items.Contains(slotitem));
            if (inventory.items.Contains(UnChared))//������ �ڵ����� �ִ� ���
            {
                inventory.items.Remove(UnChared);//������ �ڵ����� ����
                inventory.items.Add(Phone);//������ �ڵ��� �κ��丮�� �߰�
                inventory.items.Remove(Charger);
                canvasManager.Activateconversation();
                conversationScript = FindObjectOfType<conversation>();
                string[] text = new string[] { "�޴����� �����Ǿ���.", "�޴����� ������." };
                if (conversationScript == null)
                {
                    Debug.Log("����");
                }
                conversationScript.changeuitext(text);
                inventory.FreshSlot(); //�κ��丮 ����ȭ

            }
            else
            {
                canvasManager.Activateconversation();
                conversationScript = FindObjectOfType<conversation>();
                string[] text = new string[] { "�ڵ����� ã�ƺ���!!" };
                conversationScript.changeuitext(text);
            }
        }//������
        if (slotitem.itemName == "Computer")
        {
            Debug.Log("Computer");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "�ǽð� �˻��� : ���� ������ ����ȯ, 5�� �� ���..", "û�갡��..�Ƹ�� ������ ����.." };
            conversationScript.changeuitext(text);
        }//��ǻ��
        if (slotitem.itemName == "Diary")
        {
            Debug.Log("Diary");

        }//���̾
        if (slotitem.itemName == "Key")
        {
            Debug.Log("Key");
            canvasManager.Activateconversation();
            if (conversationScript == null)
            {
                Debug.Log("����");
                conversationScript = FindObjectOfType<conversation>();
            }

            string[] text = new string[] { "�׳� �����̴�." };
            conversationScript.changeuitext(text);

        }//Ű
        if (slotitem.itemName == "Medical records")
        {
            Debug.Log("Medical records");
            canvasManager.ActivateMedicalrecord();
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "���� �����Ϻ� ����.", "�Ƴ��� ���Ϸκ��� 30�� �ڿ� �� ó���� ������." };
            conversationScript.changeuitext(text);

        }//�����Ϻ�
        if (slotitem.itemName == "Postit")
        {
            Debug.Log("Postit");
            canvasManager.ActivatePostit();
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "���ڼ� ����Ʈ���̴�.", "���� ������� �𸥴�." };
            conversationScript.changeuitext(text);


        }//����Ʈ��
        if (slotitem.itemName == "Ruminol")
        {
            Debug.Log("Ruminol");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "��̳� ����̴�. ����ؼ� ������ ã�ƺ���"};
            if (conversationScript == null)
            {
                Debug.Log("����");
            }
            conversationScript.changeuitext(text);
            //��̳� ������� ��Ƽ��
            ruminol_active1.SetActive(true);
            ruminol_active2.SetActive(true);
            ruminol_active3.SetActive(true);
        }//��̳� ���

        if (slotitem.itemName == "Teacup")
        {
            Debug.Log("Teacup");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "�̴ٿ��� �Ծ��� ���� �����̴�." };
            conversationScript.changeuitext(text);
        }//����
        if (slotitem.itemName == "UnCharged")
        {
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "�Ƴ��� �ڵ����̴�.", "���͸��� �����ϴ�." };
            conversationScript.changeuitext(text);
            //������ �����ִ� �����⸦ ã�ƺ��� ��ȭâ
        }//�����ȵ� ������


        usebutton.gameObject.SetActive(false);
        throwbutton.gameObject.SetActive(false);
    }
}