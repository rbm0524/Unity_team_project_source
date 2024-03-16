using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call : MonoBehaviour
{
    public GameObject calldlekdnjs;
    public GameObject phase2;
    public GameObject bottun1;
    public GameObject bottun2;
    public conversation conversationScript;
    public ExternalCanvasManager canvasManager;
    // Start is called before the first frame update
    public void callclick()
    {
        canvasManager = FindObjectOfType<ExternalCanvasManager>();
        bottun1.SetActive(false);
        bottun2.SetActive(false);
        phase2.SetActive(false);
        calldlekdnjs.SetActive(true);
        canvasManager.Activateconversation();
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[]
        { "우선 다원 씨에게 전화를 해봐야 할 것 같아..", "<이다원>\n 여보세요?" ,"<주인공>\n다원씨 오랜만이에요. 잘 지내셨어요?","<이다원>\n 네 인공씨! 근데... 무슨 일이에요?","다원 씨의 목소리에서 불안함이 느껴진다.","<주인공>\n 다름이 아니고 물어볼게 좀 있는데..","<주인공>\n 혹시 지난 주 5월 14일 \n장미 생일에 둘이 만나셨나요??","<이다원>\n ....","<주인공>\n 장미가...다원씨랑 만난 날 이후로 연락이 안돼요.","<주인공>\n 휴대폰도 집에 놓고 어디 갔는지 모르겠어요...","<이다원>\n ...","<이다원>\n 어.. 그 날 장미랑 만나서 차를 마셨어요..","<이다원>\n 그 때 장미가 한 달 뒤 쯤에 함께 여행을 간다고 했거든요..","<이다원>\n 무슨 기념일인가 싶기도 하고..","<이다원>\n .....","<이다원>\n 인공씨..",
            "<이다원>\n 저 잠시 장미 집에 들려도 괜찮을까요?","(잠시후)","띵-동","초인종이 울린다.","<주인공>\n 다원씨 어서오세요.","<이다원>\n네.. 인공씨 요즘 몸은 괜찮으시죠?","<이다원>\n 전에 많이 힘들어 하셨잖아요.. 귀를 막아도 소리가 들린다고..","쿵!!","이다원은 손이 미끄러졌는지 핸드폰을 바닥에 떨어뜨렸다.","<이다원>\n 휴.. 액정은 안 나갔다.","<주인공>\n 잠시만 앉아 계세요.. 마실거라도 드릴게요.","<주인공>\n 어..?","부엌에서 뭔가 위화감이 든다..","<주인공>\n 이다원한테 물어볼 것을 선택해보자!" };
        conversationScript.changeuitext(text);

    }

}