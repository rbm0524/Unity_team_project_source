using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call2 : MonoBehaviour
{
    public GameObject calldlekdnjs;
    public GameObject phase2;
    public conversation conversationScript;
    public ExternalCanvasManager canvasManager;
    // Start is called before the first frame update
    public void callclick()
    {
        canvasManager = FindObjectOfType<ExternalCanvasManager>();
        phase2.SetActive(false);
        calldlekdnjs.SetActive(true);
        canvasManager.Activateconversation();
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[]
        {"<???>\n 여보세요?", "<주인공>\n 안녕하세요. 혹시 장미라는 사람을 아시나요? ", "<???>\n 어...제가 개인적으로는 모르지만 저희 고객님이 아닐까 싶네요.", "<주인공>\n 고객님이요?", "<???>\n 네 저는 택배기사입니다.",
            "(나는 택배기사한테는 어이없을 일일지도 모르지만 \n아내의 발자취를 확인하기 위해 택배기사에게 사정을 설명하였다.)", "<???>\n제가 그럼 그 날 찍혀있던 장미 고객님 주소로 방문하겠습니다.\n오늘 일정이 비는 날이거든요.", "잠시후", "<주인공>\n와주셔서 감사합니다. 바로 본론으로 넘어가자면 \n 그 날 아내를 본적이 있나요?", "<택배기사>\n 네 아내분 혼자 계시더라구요.", "<주인공>\n 아내는 무엇을 시켰었나요?", "<택배기사>\n개인정보라 말씀드리긴 곤란합니다.", "<주인공>\n아.. 알겠습니다. 편하게 앉으세요.\n 겉옷은 제가 걸어 놓을게요", "<택배기사>\n아.. 네 감사합니다.", "옷에 이름이 써져있다 조일환..", "<주인공>\n 어디서 들어본 이름같은데..\n 아 묻지마 살인사건의 피의자 이름과 똑같다..." };//택배기사 전화
        conversationScript.changeuitext(text);

    }

}