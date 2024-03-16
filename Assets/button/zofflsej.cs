using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zofflsej : MonoBehaviour//달력
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "<주인공>\n 다원씨 장미 생일 때 장미랑 만난 후에 연락한 적 있었나요?", "<이다원>\n 아니요.. 그 날 이후로 따로 연락하진 않았어요", "<주인공>\n 다른 선택지를 선택해보자!" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
