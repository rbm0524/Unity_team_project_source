using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{
    public conversation conversationScript;
    public GameObject button;
    // Start is called before the first frame update
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "<주인공>\n 다원씨 궁금한게 있는데요.. TV에 지문들이 찍혀있던데 혹시 아시나요?", "<이다원>\n 아니요 그건 잘 모르겠어요..", "<주인공>\n 다른 선택지를 선택해보자!" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
