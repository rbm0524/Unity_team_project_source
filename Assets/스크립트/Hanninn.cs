using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hanninn : MonoBehaviour
{
    public Conversation_police conversationScript;
    public GameObject conversationCanvas;

    public InputField input_name;
    private string playerName1 = "�̴ٿ�";
    private string playerName2 = "���ΰ�";
    private string playerName3 = "���ȱ�";
    private string playerName4 = "����ȯ";


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (input_name.text.Length > 0 && Input.GetKeyDown(KeyCode.Return))//����Ű ��������
        {
            if (playerName1 == input_name.text)
            {
                SceneManager.LoadScene("main");
                //�̴ٿ�


            }
            if (playerName2 == input_name.text)
            {
                SceneManager.LoadScene("Success");
                //���ΰ�  
                
            }
            if (playerName3 == input_name.text)
            {
                SceneManager.LoadScene("main");
                //���ȱ�
            }
            if (playerName4 == input_name.text)
            {
                SceneManager.LoadScene("main");
                //����ȯ
            }
        }
    }

}