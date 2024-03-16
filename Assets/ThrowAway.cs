using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAway : MonoBehaviour
{
    private Inventory inventory;
    public Slot slot;
    public Transform buttonParent1; // 새로운 버튼을 생성할 부모 오브젝트
    public Transform buttonParent2;
    private void Start()
    {
        inventory = FindObjectOfType<Inventory>(); // Inventory 클래스의 인스턴스를 찾아서 할당합니다.
    }

    public void RemoveItem(Item itemToRemove)
    {
        inventory.items.Remove(itemToRemove); // Inventory 클래스의 items 리스트에서 아이템을 제거합니다.
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