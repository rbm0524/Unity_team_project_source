using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_hannin : MonoBehaviour
{
    public Conversation_hannnin conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_hannnin>();
        string[] text = new string[] {"....","갑자기 정신이 뚜렷해진다.","나는 아내를 죽인 사람을 죽이고자 마음 먹었다.","도저히 입이 떨어지지 않는다.",
                                       "끝내 나는 경찰에게 말을 하지 못하였다.","<주인공>\n 몸이 안 좋아서.. 먼저 집에 들어가 보겠습니다.. 죄송합니다.",
                                        "경찰에게 말을 남긴 뒤 집으로 돌아왔다.","아까 옥상에 가기 전 떠올렸던 장면의 색이 칠해지기 시작했다.",
                                        "지난 일주일 간 백지상태였던 기억도 돌아오고 있었다.","아내를 꽉 끌어안고 왼손에는 칼을 쥐고 있는 내가 보였다.",
                                        "아내를 들고 있는 팔에 힘이 풀리며 아내가 떨어지는 소리도 들리는 듯 한다.","아내와 그렇게 안고 있을 수 있었던 사람이 누가 있을까..",
                                        "모든 상황과 나의 기억들이","나를 가리키고 있다.","일주일 전 아내와 함께 올라갔던 것처럼 터벅터벅 옥상으로 올라갔다.",
                                        "아내를 죽인 범인을 죽이겠다는 결심은 이내 분노로 바뀌었고","범인을 용서할 수 없다는 생각만이 가득했다.","나는 아내를 죽인 범인을 죽이기로 결심했다.",
                                        ".....","쿵..!","몸은 조금 아팠지만 속은 후련하다.","나를 괴롭히던 소리들도 더 이상 들리지 않는다.","아내를 죽인 범인을 찾았으니 이제 편히 잘 수 있을 것 같다..",
                                        "'며칠 전 경기도에서 실종된 여성이 사실은 살해 당한 것이라는 경찰 조사 결과가 나왔습니다..'","'범인은 그의 남편 33세 주 모씨였으며, 최근 몇 년 간 정신병 증세를 앓고있었던 것으로..'","'범인은 경찰에 신고한 후 자신의 몸을 옥상에서 던져 스스로 목숨을 끊었습..'"};
        conversationScript.changeuitext(text);

    }

}


