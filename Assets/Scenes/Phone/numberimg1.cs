using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class numberimg1 : MonoBehaviour
{
    private Phone Phone;
    public Image image1;
    private void Start()
    {
        image1.color = new Color(1f, 1f, 1f, 0.29f);
    }
    void Update()
    {
 
        if (Phone.passwd.Count > 1)
        {
            image1.color = new Color(1, 1, 1, 1);
        }
        else
        {
            image1.color = new Color(1f, 1f, 1f, 0.29f);
            
        }
    }

}
