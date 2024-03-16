using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_police : MonoBehaviour
{
    public Conversation_police conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_police>();
        string[] text = new string[] { "<경찰>\n 네.. 신고 접수 됐습니다.","<경찰>\n  특정짓긴 어렵지만 타살일 가능성이 높습니다.",
                                        "<경찰>\n 우선 수사를 진행하겠습니다.","경찰이 추가적인 정보를 찾아냈다.","찻잔 : 결혼 예물로 산 찻잔이다.이다원의 오른손 지문이 묻어있다.",
                                        "TV지문: 조일환의 지문이었다.","카펫트 굳은 부분: 성분을 분석해보니 라벤더 티와 청산가리가 섞인 액체가 굳은 것이었다.","아내의 시체: 사인은 부엌칼로 인한 과다출혈이다.",
                                        "등 왼쪽 부분에 칼에 찔린 흔적이 있다.","아내의 옷에는 청산가리가 들어간 라벤더 티가 묻어있다.","범인은 누구일까?"};
        conversationScript.changeuitext(text);

    }

}


