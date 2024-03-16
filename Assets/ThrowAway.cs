using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAway : MonoBehaviour
{
    private Inventory inventory;
    public Slot slot;
    public Transform buttonParent1; // ���ο� ��ư�� ������ �θ� ������Ʈ
    public Transform buttonParent2;
    private void Start()
    {
        inventory = FindObjectOfType<Inventory>(); // Inventory Ŭ������ �ν��Ͻ��� ã�Ƽ� �Ҵ��մϴ�.
    }

    public void RemoveItem(Item itemToRemove)
    {
        inventory.items.Remove(itemToRemove); // Inventory Ŭ������ items ����Ʈ���� �������� �����մϴ�.
    }
    public void onclick()
    {
        Item itemtoremove = slot.GetItem();
        RemoveItem(itemtoremove);
        inventory.FreshSlot();
        buttonParent1.gameObject.SetActive(false);
        buttonParent2.gameObject.SetActive(false);
    }

}