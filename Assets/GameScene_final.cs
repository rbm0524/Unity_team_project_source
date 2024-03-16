using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene_final : MonoBehaviour
{
    public GameObject GameButton; // Start 버튼을 가진 GameObject를 참조합니다.

    public void GameScnesCtrl()
    {
        SceneManager.LoadScene("main"); //어떤 씬으로 이동할 지

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


