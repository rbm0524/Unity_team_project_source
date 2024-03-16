using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    private Phone Phone;
    // Start is called before the first frame update
    public void onclick()
    {
        if (Phone.passwd.Count == 4)
        {
            List<int> comparisonList = new List<int> { 0, 6, 1, 2 }; // ���� ����Ʈ

            if (AreListsEqual(Phone.passwd, comparisonList))
            {
                Debug.Log("List match!"); // �� ����Ʈ�� ������ ��Ҹ� ������ ���� ��
                phase.phase_num = 2;
            }
            else
            {
                Debug.Log("List mismatch!"); // �� ����Ʈ�� �ٸ� ��Ҹ� ������ ���� ��
            }
            Phone.passwd = new List<int>();
        }
    }

    private bool AreListsEqual(List<int> list1, List<int> list2)
    {
        if (list1.Count != list2.Count)
            return false;

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
                return false;
        }

        return true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
