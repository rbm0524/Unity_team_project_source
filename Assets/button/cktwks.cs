using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cktwks : MonoBehaviour//찻잔
{
    public conversation conversationScript;
    public GameObject button;
    // Start is called before the first frame update
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "(식탁에는 찻잔이 하나 밖에 없었어..)", "(아내 혼자 마셨을거라 생각했는데..)",
            "(다원씨도 같이 차를 마셨다고..?)", "주위를 둘러보았지만 또 다른 찻잔은 존재하지 않았다.",
            "<주인공>\n 다원씨 차.. 싫어하세요?", "<이다원>\n 아니요..?", "<주인공>\n 다원씨, 같이 티타임을 즐겼다면서요.",
            "<주인공>\n 그런데 왜 식탁에는 찻잔이 하나밖에 없나요?", "<이다원>\n 인공씨가 치운거 아니에요?",
            "<주인공>\n 저는 아내 생일 이후에 이 집을 방문한 적이 없어요.", "<주인공>\n 그리고 아내의 흔적을 찾기 위해 집에 있는 물건을 그대로 두었고요.", "<이다원>\n 그럼 장미가 치웠겠죠.", "(물론 그럴 수 있다)"
            , " (하지만 이 찻잔은 우리 결혼 예물로 산 거라 세트로 맞춘 것이란 말이야)", "(아내가 치웠으면 어딘가에 있어야 하는데 흔적조차 없어..)",
            "(분명 다원씨는 나한테 무언가를 숨기고 있다)" };
        conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
