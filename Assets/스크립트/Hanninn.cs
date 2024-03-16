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
    private string playerName1 = "이다원";
    private string playerName2 = "주인공";
    private string playerName3 = "서팔광";
    private string playerName4 = "조일환";


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (input_name.text.Length > 0 && Input.GetKeyDown(KeyCode.Return))//엔터키 눌렀을때
        {
            if (playerName1 == input_name.text)
            {
                SceneManager.LoadScene("main");
                //이다원


            }
            if (playerName2 == input_name.text)
            {
                SceneManager.LoadScene("Success");
                //주인공  
                
            }
            if (playerName3 == input_name.text)
            {
                SceneManager.LoadScene("main");
                //서팔광
            }
            if (playerName4 == input_name.text)
            {
                SceneManager.LoadScene("main");
                //조일환
            }
        }
    }

}