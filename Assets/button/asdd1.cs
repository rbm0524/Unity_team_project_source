using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class asdd1 : MonoBehaviour//이름을 물어본다.
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        SceneManager.LoadScene("kill");
        //string[] text = new string[] { "<주인공>\n 기사님 혹시 이름을 여쭈어봐도 괜찮을까요..?", "<택배기사>\n ....", "<택배기사>\n 죄송합니다 제 이름이 특이해서 어릴적부터 놀림을 받곤 했습니다.", "<택배기사>\n 그래서 밝히고 싶지 않습니다..", "<주인공>\n 조일..환이 그렇게 특이한 이름인가요?", "(택배기사는 나의 말을 무시하고 그 자리에서 조용히 일어나 문을 열고 나갔다)", "<주인공>\n ....?", "(그렇게 이틀이 지났다. 나는 아내를 찾지 못했다. 아내를 찾지 못한 서러움에 새벽에 산책을 나갔다)", "푹...", "(그 순간..나의 등엔 축축한 느낌이 들었고 아픈 고통까지 느껴졌다.)", "(택배기사였다.. 택배기사는 손에 나의 피를 묻힌 채 무표정으로 내가 쓰러지는 모습을 보고 있었다.)", "<택배기사>\n 그러게..서로 몰랐으면 좋았잖아?", "(그렇게 나는 이 말을 끝으로 의식을 완전히 잃었다)" };
        //conversationScript.changeuitext(text);
        button.SetActive(false);
    }
}
