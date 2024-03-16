using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passwdremove : MonoBehaviour
{
    private Phone Phone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void removepasswd()
    {
        if (Phone.passwd.Count >= 1)
        {
            Phone.passwd.RemoveAt(Phone.passwd.Count - 1); // 마지막 원소 제거
        }
    }
}
