using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUi : MonoBehaviour
{
    public GameObject inventoryPanel;
    public bool activeInventory = false;
    public Slot[] slots;
    public Transform sloatHolder;

    private void Start()
    {
        slots = sloatHolder.GetComponentsInChildren<Slot>();
        inventoryPanel.SetActive(activeInventory);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (activeInventory == false) {

                Cursor.lockState = CursorLockMode.None; // 마우스 커서를 화면 안에 가둠
                Cursor.visible = true; // 마우스 커서를 보이지 않게 설정
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

            }
            activeInventory = !activeInventory;
            
            inventoryPanel.SetActive(activeInventory);
        }
    }
}
