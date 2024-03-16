using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_roof : MonoBehaviour
{
    public Conversation_roof conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_roof>();
        string[] text = new string[] { "(끼---익)", "옥상에 올라왔다.", "퀘퀘한 심하게 냄새가 난다. ", "옥상에는 헌 물탱크가 존재한다.", "(나는...헌 물탱크를 열어보았다.)",
                                        ".....","........","장..장미야..","안에는 꽤 시체가 훼손된 상태로 아내의 시체가 있다","참을 수 없는 냄새에 나의 손 발이 떨려온다.","왼쪽 등에 칼에 깊이 찔린 상처가 보인다.",
                                        "누군가 세게 안았던 것처럼.. 등과 가슴 쪽에 멍이 들어있다.","<주인공>\n 아내를 죽인 범인 내가 꼭 찾아 죽일거야....","<주인공>\n 이젠 경찰에 신고를 해야할 것 같아..",
                                        "(집 안에 집 전화기가 있었는데 그것을 이용해 경찰에 연락하자)","('H'키를 눌러 집으로 돌아가자)"};
        conversationScript.changeuitext(text);

    }
}


