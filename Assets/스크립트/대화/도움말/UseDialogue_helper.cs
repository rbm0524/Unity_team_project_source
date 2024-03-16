using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseDialogue_helper : MonoBehaviour
{
    public Conversation_helper conversationScript;
    public GameObject conversationCanvas;



    public void Start()
    {
        conversationCanvas.SetActive(true);
        conversationScript = FindObjectOfType<Conversation_helper>();
        string[] text = new string[] { "<교수님>\n(Space키를 눌러봐~대사가 진행돼 알겠지~?)","<교수님>\n안녕, 나는 이 게임의 전반적인 조작법을 알려주는 헬퍼야\n(Space키를 눌러봐~대사가 진행돼 알겠지~?)", "<교수님>\n 이 게임은 증거품을 수집하면서 추리하는 게임이야~", "<교수님>\n 증거물 수집은 'F'키를 누르면 돼~", "<교수님>\n 수집한 증거물을 확인하는 키는 'I'키야~", "<교수님>\n 움직이는 것은 W,A,S,D키로 움직이면 돼~", "<교수님>\n 방향은 마우스로 움직여봐~", "<교수님>\n 집 전화기를 사용할 경우 무조건 범인 한명을 지목해야되니 주의해", "<교수님>\n 그럼 알아서 잘해봐잉"  };
        conversationScript.changeuitext(text);

    }

}


