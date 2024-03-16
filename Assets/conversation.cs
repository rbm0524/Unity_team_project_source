using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conversation : MonoBehaviour
{
    public Text uiText;
    string[] conversationarray;
    public GameObject conversationPanel;
    public GameObject buttonParent1; // 새로운 버튼을 생성할 부모 오브젝트
    public GameObject buttonParent2;
    public GameObject buttonParent3; // 새로운 버튼을 생성할 부모 오브젝트
    bool button_act1;
    bool button_act2;
    bool button_act3;
    private void Start()
    {
         button_act1=false;
         button_act2= false;
         button_act3= false;
        //uiText.text = "첫 번째 줄\n두 반째";
        buttonParent1.gameObject.SetActive(false);
        buttonParent2.gameObject.SetActive(false);
        buttonParent3.gameObject.SetActive(false);
    }

    public void changeuitext(string[] text1)
    {
        if (uiText == null)
        {
            uiText = FindObjectOfType<Text>();
        }
        uiText.text = text1[0];
        conversationarray = text1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            buttonParent1.gameObject.SetActive(false);
            buttonParent2.gameObject.SetActive(false);
            buttonParent3.gameObject.SetActive(false);

            if (uiText.text == conversationarray[conversationarray.Length - 1]& button_act1 != true&button_act3 != true)
            {
                conversationPanel.SetActive(false);
            }
            for (int i = 0; i < conversationarray.Length - 1; i++)
            {
                if (uiText.text == conversationarray[i])
                {
                    uiText.text = conversationarray[i + 1];
                    break;
                }
            }
            if (uiText.text == "<주인공>\n 이다원한테 물어볼 것을 선택해보자!")//선택지를 만드는 문장
            {

                buttonParent1.gameObject.SetActive(true);
                button_act1 = true;
            }
            if (uiText.text == "<주인공>\n 다른 선택지를 선택해보자!")//버튼마다 대사 출력 후에 다시 돌아가기
            {
                buttonParent1.gameObject.SetActive(true);
                button_act1 = true;
            }
            if (uiText.text == "<주인공>\n 어디서 들어본 이름같은데..\n 아 묻지마 살인사건의 피의자 이름과 똑같다...")//선택지를 만드는 문장
            {
                buttonParent3.gameObject.SetActive(true);
                button_act3 = true;

                //버튼 활성화
                //버튼마다 대사 출력 후에 다시 돌아가기
            }


            if (uiText.text == "(분명 다원씨는 나한테 무언가를 숨기고 있다)")//선택지를 만드는 문장
            {
                
                button_act1 = false;

                //버튼 활성화
                //버튼마다 대사 출력 후에 다시 돌아가기
            }
            if (uiText.text == " 밖에 나가서 사오자..")//선택지를 만드는 문장
            {

                button_act3 = false;

                //버튼 활성화
                //버튼마다 대사 출력 후에 다시 돌아가기
            }
            
        }
    }
}
