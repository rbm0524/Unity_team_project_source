using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitcall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject calldlekdnjs;
    public GameObject phase2;
    // Update is called once per frame
    public void outcall()
    {
        calldlekdnjs.SetActive(false);
        phase2.SetActive(true);
    }
}
