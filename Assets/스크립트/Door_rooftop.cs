using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_rooftop : MonoBehaviour
{
    public GameObject RooftopCanvas;// ���� �׸��� ���� ĵ����

    private void Start()
    {
        RooftopCanvas.SetActive(false);
    }

    private void OnMouseDown()
    {
        RooftopCanvas.SetActive(true);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            RooftopCanvas.SetActive(false);
        }
    }
}

