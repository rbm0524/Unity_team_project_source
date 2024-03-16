using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalCanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject postitcanvas;
    public GameObject medicalrecordcanvas;
    public GameObject calendercanvas;
    public GameObject phonecanvas;
    public GameObject conversation;
    public void ActivatePostit()
    {
        postitcanvas.SetActive(true);
    }
    public void ActivateMedicalrecord()
    {
        medicalrecordcanvas.SetActive(true);


    }
    public void ActivateCanlender()
    {
        calendercanvas.SetActive(true);
    }
    public void ActivatePhone()
    {
        phonecanvas.SetActive(true);
    }
    public void Activateconversation()
    {
        conversation.SetActive(true);
    }
}