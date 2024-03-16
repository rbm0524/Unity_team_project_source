using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickUpItem : MonoBehaviour
{
    public TextMeshProUGUI Text; // Text 오브젝트 연결을 위한 public 변수
    public GameObject a;
    private Inventory inventory;
    public Item Phone;
    public Item Calender;
    public Item Charger;
    public Item Computer;
    public Item Diary;
    public Item Key;
    public Item Medicalrecord;
    public Item Ruminol;
    public Item Teacup;
    public Item Uncharged;
    public GameObject inventorycanvas;
    public Item Post_it;
    string[] textall = null;

    public void print()
    {
          string objectName = Player.collidedObjectName; // collidedObjectName 변수의 값을 가져옴
          if(objectName == "TV")
          {
              if (Text == null)
              {
                    Text = FindObjectOfType<TextMeshProUGUI>();
              }

              string[] text = new string[] { "처음 보는 TV이다.", "알 수 없는 지문들이 꽤 많이 찍혀있다." };
              textall = text;
              Text.text = textall[0];
          }

        if (objectName == "stain")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "카페트 : 카페트에 유리조각이 떨어져 있다", "카페트 얼룩 : 어떤 액체가 굳어 딱딱해진 부분이 있다." };
            textall = text;
            Text.text = textall[0];
        }

        if (objectName == "Table")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "찻잔 하나가 놓여져 있다.", "먼지가 쌓여있다."};
            textall = text;
            Text.text = textall[0];
        }

        if (objectName == "VintageTelephone")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "경찰에 신고했다." };
            textall = text;
            Text.text = textall[0];

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; // 마우스 커서를 보이게
            SceneManager.LoadScene("Telephone"); // sceneToLoad에 저장된 씬으로 전환

        }

        if (objectName == "Trashcan")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "약이 30일 분이 버려져 있다." };
            textall = text;
            Text.text = textall[0];

        }

        if (objectName == "루미놀 1")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "(아내의 휴대폰으로 자기에게 전화를 건다.)", "(버튼 1번이 나로 저장되어 있구나..)","피로 물든 카페트와 가구들을 보니 갑자기 머리가 아프다.","중얼거리는 소리가 들린다..","요즘 안 그랬었는데.. 갑자기 심해진 것 같다..","갑자기 누군가가 아내를 안고 있는 장면이 떠올랐다.. 꽤나 세게 안고 있는 것 같다..","아내는 힘이 빠진 듯 그 상대방의 몸에 기대어서 몸을 늘어뜨리고 있다.","...","또 중얼거리는 소리가 들린다.","갑자기 누군가가 아내를 들쳐메고 옥상으로 향하는 장면이 떠올랐다..","왠지,. 옥상에 가봐야 할 것 같다.", "문을 열고 옥상으로 가보자"};
            textall = text;
            Text.text = textall[0];

        }

        if (objectName == "Medicine")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "정확히 30일 분의 약이 들어있다.", "쓰레기통에 있는 약과 같은 약 같다." };
            textall = text;
            Text.text = textall[0];
        }

        if (objectName == "Computer")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "실시간 검색어 : 살인 피의자 조일환, 5달 전 출소..", "청산가리.. 아몬드 냄새와 유사.." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Computer);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Phone")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "아내의 휴대폰이다.", "배터리가 부족하다.." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Uncharged);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Supplementary battery")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "완충된 보조배터리이다." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Charger);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Medical records")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "나의 진료기록부 같다..", "아내의 생일로부터 30일 뒤에 약 처방이 끝난다." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Medicalrecord);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Post-it")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "그 순간 급하게 누르는 초인종 소리가 들린다.", "(띠띠띠띠띠띠띠띠---잉 동)", "???: 야! 너네 조용히 하라고 했지\n 한동안 잠잠하더니 또 그러네?",
                "내가 한 번 더 시끄럽게 하면 죽인다고 했지?\n 너 오늘 제삿날이다.문열어!!", "(나는 문을 열었고 거기에는 아내의 아랫집에 살고 있는 서팔광이 서있었다.)", "서팔광이 다원씨를 손으로 가리켰다.", "서팔광: 하.. 일주일 전에도 와서 시끄럽게 하더니 오늘도 와서 똑같이 시끄럽게 하네!", "서팔광: 그때는 포스트잇으로 경고했는데..!", "서팔광: 오늘은 진짜 못 참겠어!", "주인공: (아 아침에 찾은 포스트잇이 이 사람이 쓴 것이구나)","(포스트잇에는 층간 소음으로 스트레스를 받고 있다는 말과 함께 살인 협박이 가득히 들어있었다.)", "(예전 이 집을 살 때 전직 조폭이 살고 있다고 들었는데 그 사람이 이 사람인가 보다.) 나는 두려움을 참고 서팔광에게 물었다.)", "주인공: 일주일 전에도 라고 했는데 그때가 정확히 언젭니까?", "서팔광: 일주일 전이라고 했잖아XX!", "주인공: (일주일 전이면 다원씨가 방문한 날짜 그리고 아내의 생일이자 실종 날짜와 동일하다."};
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Post_it);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Calender")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "5월이 펼쳐진 달력이다.", "5월 14일 날 누군가 만난 것 같다." };
            textall = text;
            Text.text = textall[0];
            inventorycanvas.SetActive(true);
            inventory = FindObjectOfType<Inventory>();
            inventory.AddItem(Calender);
            inventorycanvas.SetActive(false);
        }

        if (objectName == "Kitchen Knife")
        {
            if (Text == null)
            {
                Text = FindObjectOfType<TextMeshProUGUI>();
            }

            string[] text = new string[] { "꽤나 날카로운 부엌칼이다.." };
            textall = text;
            Text.text = textall[0];
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //false로 바꿀 필요x
        {
            try
            {
                if (Text.text == textall[textall.Length - 1])
                {
                    a.SetActive(false);
                    //Text.text를 null로 해놓을 이유가 있는가
                }
                else
                {
                    for (int i = 0; i < textall.Length - 1; i++)
                    {
                        if (textall[i] == Text.text)
                        {
                            Text.text = textall[i + 1];
                            break;
                        }
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                // 예외를 무시하고 넘어감
            }
        }
    }
}