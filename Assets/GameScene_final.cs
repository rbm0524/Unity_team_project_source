using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene_final : MonoBehaviour
{
    public GameObject GameButton; // Start ��ư�� ���� GameObject�� �����մϴ�.

    public void GameScnesCtrl()
    {
        SceneManager.LoadScene("main"); //� ������ �̵��� ��

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


