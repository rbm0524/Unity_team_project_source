using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdd2 : MonoBehaviour
{
    // Start is called before the first frame update
    public conversation conversationScript;
    public Item Ruminol;
    public GameObject inventorycanvas;
    private Inventory inventory;
    public GameObject button;
    public void onclick()
    {
        conversationScript = FindObjectOfType<conversation>();
        string[] text = new string[] { "<주인공>\n ...","<주인공>\n 그럼 그 날 TV만 전달해주고 바로 가셨었나요??","<택배기사>\n 네 맞습니다.","<주인공>\n 아깐 그냥 전자제품이라고만 하셨는데 TV가 맞나보네요..?","<택배기사>\n ...","<택배기사>\n 네.. 고객님께 택배를 전달해드리고 저는 바로 갔습니다.","(뭔가 이상하다.. 집에 아무도 없던 것도 아니고..)","(무거운 TV를 그냥 두고 갔을 리가 없다..)","<주인공>\n 오래 사용하지도 않은 TV에 알 수 없는 지문이 많이 찍혀 있습니다.","<택배기사>\n 지문은.. 제가 자라 모르겠습니다..","<택배기사>\n 고객님의 눈을... 보니 굉장히 화가 많이 나셨네요..","<택배기사>\n 병원에 가보셔야 할 것 같습니다..","(택배기사가 집을 나간다.)","<주인공>\n 이거 단순히 아내가 사라진 것이 맞나..?","<주인공>\n 아까 집을 보니 장판에 이상한 흔적들이 많았어..","<주인공>\n 루미놀 용액을 뿌리면 핏자국이 나온다는데.."," 밖에 나가서 사오자.." };
        conversationScript.changeuitext(text);

        inventory = FindObjectOfType<Inventory>();
        inventory.AddItem(Ruminol);

        button.SetActive(false);
    }
}
