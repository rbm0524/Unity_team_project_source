using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue : MonoBehaviour
{
    public Conversation_a conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_a>();
        string[] text = new string[] { "따르릉..! 따르릉..!", "알람소리가 들린다.", "<주인공>\n 으...","한 일주일 정도 된 것 같다.","기억은 희미하고 머리는 깨질 듯 아프다.","요즘 들어 어지럼증과 강박증도 심해진 것 같다.","잠을 못잔 탓 인가","불안한 느낌은 들지만 하루 이틀이 아닌 터라 그대로 누워 휴대폰을 켰다.","<주인공>\n 5월 21일..","<주인공>\n 일주일 전 아내의 생일을 챙겼었나..?","<주인공>\n 내가 그 날을 잊을 리가 없는데..","<주인공>\n 아니 그보다 지난 일주일간 연락을 하긴 했었나..","갑자기 불안하다..","아내에게 전화를 걸어보자..","(전원이 꺼져있어.. 음성 사서함으..)","<주인공>\n 음...","<주인공>\n안되겠다.. 직접 찾아가보자","....","띵-동","<주인공>\n 어디 나갔나...?","끼이익..","<주인공>\n 장미야...?","<주인공>\n아무도 없네.."  };
        conversationScript.changeuitext(text);

    }
}


