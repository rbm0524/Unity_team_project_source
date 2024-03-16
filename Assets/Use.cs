using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Use : MonoBehaviour
{
    private Inventory inventory;//인벤토리함수
    public conversation conversationScript;
    public Slot slot;
    public Item UnChared;
    public Item Phone;
    public Item Charger;
    public Transform usebutton; // 버튼
    public Transform throwbutton;//버튼
    public ExternalCanvasManager canvasManager; //외부 캔버스를 가져올 인스턴스
    //루미놀
    public GameObject ruminol_active1;//부엌칼
    public GameObject ruminol_active2; //거실 바닥
    public GameObject ruminol_active3;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void onclick()
    {
        canvasManager = FindObjectOfType<ExternalCanvasManager>();//외부 캔버스 인스턴스 할당
        Item slotitem = slot.GetItem();
        inventory = FindObjectOfType<Inventory>();//인벤토리에서 객체 반환 
        //여기부터 use 버튼 클릭시에 행동할 이밴트
        if (slotitem.itemName == "Phone")//충전된 핸드폰
        {
            Debug.Log("phone");
            canvasManager.ActivatePhone();

        }//핸드폰
        if (slotitem.itemName == "Calender")
        {
            canvasManager.ActivateCanlender();
            Debug.Log("Calender");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "5월이 펼쳐진 달력이다.", "5월 14일 날 누군가 만난 것 같다." };
            conversationScript.changeuitext(text);

        }//캘린더
        if (slotitem.itemName == "Charger")//핸드폰 충전
        {
            Debug.Log(inventory.items.Contains(slotitem));
            if (inventory.items.Contains(UnChared))//방전된 핸드폰이 있는 경우
            {
                inventory.items.Remove(UnChared);//방전된 핸드폰을 지움
                inventory.items.Add(Phone);//충전된 핸드폰 인벤토리에 추가
                inventory.items.Remove(Charger);
                canvasManager.Activateconversation();
                conversationScript = FindObjectOfType<conversation>();
                string[] text = new string[] { "휴대폰이 충전되었다.", "휴대폰이 켜졌다." };
                if (conversationScript == null)
                {
                    Debug.Log("없음");
                }
                conversationScript.changeuitext(text);
                inventory.FreshSlot(); //인벤토리 동기화

            }
            else
            {
                canvasManager.Activateconversation();
                conversationScript = FindObjectOfType<conversation>();
                string[] text = new string[] { "핸드폰을 찾아보자!!" };
                conversationScript.changeuitext(text);
            }
        }//충전기
        if (slotitem.itemName == "Computer")
        {
            Debug.Log("Computer");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "실시간 검색어 : 살인 피의자 조일환, 5달 전 출소..", "청산가리..아몬드 냄새와 유사.." };
            conversationScript.changeuitext(text);
        }//컴퓨터
        if (slotitem.itemName == "Diary")
        {
            Debug.Log("Diary");

        }//다이어리
        if (slotitem.itemName == "Key")
        {
            Debug.Log("Key");
            canvasManager.Activateconversation();
            if (conversationScript == null)
            {
                Debug.Log("없음");
                conversationScript = FindObjectOfType<conversation>();
            }

            string[] text = new string[] { "그냥 열쇠이다." };
            conversationScript.changeuitext(text);

        }//키
        if (slotitem.itemName == "Medical records")
        {
            Debug.Log("Medical records");
            canvasManager.ActivateMedicalrecord();
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "나의 진료기록부 같다.", "아내의 생일로부터 30일 뒤에 약 처방이 끝난다." };
            conversationScript.changeuitext(text);

        }//진료기록부
        if (slotitem.itemName == "Postit")
        {
            Debug.Log("Postit");
            canvasManager.ActivatePostit();
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "협박성 포스트잇이다.", "누가 썼는지는 모른다." };
            conversationScript.changeuitext(text);


        }//포스트잇
        if (slotitem.itemName == "Ruminol")
        {
            Debug.Log("Ruminol");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "루미놀 용액이다. 사용해서 혈흔을 찾아보자"};
            if (conversationScript == null)
            {
                Debug.Log("없음");
            }
            conversationScript.changeuitext(text);
            //루미놀 용액으로 엑티브
            ruminol_active1.SetActive(true);
            ruminol_active2.SetActive(true);
            ruminol_active3.SetActive(true);
        }//루미놀 용액

        if (slotitem.itemName == "Teacup")
        {
            Debug.Log("Teacup");
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "이다원이 먹었을 듯한 찻잔이다." };
            conversationScript.changeuitext(text);
        }//찻잔
        if (slotitem.itemName == "UnCharged")
        {
            canvasManager.Activateconversation();
            conversationScript = FindObjectOfType<conversation>();
            string[] text = new string[] { "아내의 핸드폰이다.", "배터리가 부족하다." };
            conversationScript.changeuitext(text);
            //충전이 꺼져있다 충전기를 찾아보자 대화창
        }//충전안된 충전기


        usebutton.gameObject.SetActive(false);
        throwbutton.gameObject.SetActive(false);
    }
}