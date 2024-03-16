using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottonmake : MonoBehaviour
{
    // Start is called before the first frame update

    public Slot slot;
    public Transform buttonParent1; // 새로운 버튼을 생성할 부모 오브젝트
    public Transform buttonParent2;
    bool button_cur = false;
    private void Start()
    {
        buttonParent1.gameObject.SetActive(button_cur);
        buttonParent2.gameObject.SetActive(button_cur);
    }
    public void CreateNewButton()
    {
        Item itemtoremove = slot.GetItem();
        if (itemtoremove != null | button_cur==true)
        {
            button_cur = !button_cur;

            buttonParent1.gameObject.SetActive(button_cur);
            buttonParent2.gameObject.SetActive(button_cur);
        }
        
    }
}
