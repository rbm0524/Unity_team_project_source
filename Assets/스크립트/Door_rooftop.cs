using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_rooftop : MonoBehaviour
{
    public GameObject RooftopCanvas;// ¿Á»ó ±×¸²ÀÌ ºÙÀº Äµ¹ö½º

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

