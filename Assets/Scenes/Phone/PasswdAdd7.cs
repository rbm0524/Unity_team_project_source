using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswdAdd7 : MonoBehaviour
{
    private Phone Phone;
    // Start is called before the first frame update
    public void addpasswd()
    {
        if (Phone.passwd.Count < 4)
        {
            Phone.passwd.Add(7);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
