using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phase : MonoBehaviour
{
    public static int phase_num; //phase가 1이면 비밀번호 입력, phase가 2이면 키패드
    public GameObject phase1;
    public GameObject phase2;
    public GameObject dial;
    public GameObject call1;
    public GameObject call2;
    public GameObject call3;
    // Start is called before the first frame update
    void Start()
    {
        phase_num = 1;
        phase1.SetActive(true);
        phase2.SetActive(false);
        dial.SetActive(false);
        call3.SetActive(false);
        call1.SetActive(false);
        call2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (phase_num == 1)
        {
            phase1.SetActive(true);
            phase2.SetActive(false);
        }
        else if (phase_num == 2)
        {
            phase1.SetActive(false);
            phase2.SetActive(true);
        }
    }
}
