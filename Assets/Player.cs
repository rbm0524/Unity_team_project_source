using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool Getitem;
    private Rigidbody myRigid;
    public GameObject nearObject;
    public float interactionDistance = 3f;
    public GameObject Conversation;
    public static string collidedObjectName;

    public float movementSpeed; // 이동 속도 설정
    public float mouseSensitivity = 2f; // 마우스 감도 설정
    private float rotationX = 0f;
    private Inventory inventory;
    public GameObject ruminol_active1;//부엌칼
    public GameObject ruminol_active2; //거실 바닥
    public GameObject ruminol_active3;

    public bool isConversation;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 2.5f;
        Conversation.SetActive(false);
        myRigid = GetComponent<Rigidbody>();
        LockAndHideCursor();
        ruminol_active1.SetActive(false);
        ruminol_active2.SetActive(false);
        ruminol_active3.SetActive(false);
    }

    private void Awake()
    {
        // Awake 메서드 내에서 FindObjectsOfType 함수 호출
        GameObject[] proofObjects = FindObjectsOfType<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleMouseLook();

        GetInput();
        Get();
    }

    private void LockAndHideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서를 화면 안에 가둠
        Cursor.visible = false; // 마우스 커서를 보이지 않게 설정
    }

    private void HandleMovement()
    {
        // 플레이어 이동 처리
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * movementSpeed  * Time.deltaTime;
        transform.Translate(movement);
    }

    private void HandleMouseLook()
    {
        // 마우스 시점 변경 처리
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // 좌우 회전
        transform.Rotate(Vector3.up * mouseX);

        // 상하 회전
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        Camera.main.transform.localEulerAngles = new Vector3(rotationX, 0f, 0f);
    }

    public void OnTriggerStay(Collider collider2)
    {
        if (collider2.transform.parent != null)
        {
            GameObject parentObject = collider2.transform.parent.gameObject;
            if (parentObject.CompareTag("Proof") || parentObject.CompareTag("non-Proof") || parentObject.CompareTag("another"))
            {
                nearObject = parentObject;
            }
        }
    }

    void GetInput()
    {
        Getitem = Input.GetButtonDown("Get"); // f를 입력 시 Getitem을 true input manager에서 Get이란 이름으로 하나 생성 positive key 입력
    }

    void Get()
    {
        if (Getitem && nearObject != null) // Getitem이 true이고 nearObject가 not null일 때
        {
            if (nearObject.tag == "Proof") // 충돌한 것의 tag가 Proof면 실행
            {
                collidedObjectName = nearObject.gameObject.name; //충돌한 오브젝트 이름 저장
                Debug.Log(collidedObjectName); // 오브젝트 이름 출력 (tag가 아님)
                    Destroy(nearObject);
                    // isDestroy를 true로 만들고 Proof 스크립트에서 처리
                    Conversation.SetActive(true); //대화창이 떴고 Conversation 스크립트 진행하고 대화 끝나면 Conversation.SetActive를 false로 Conversation 스크립트에서 조정
                    GetComponent<pickUpItem>().print();

            }

            if (nearObject.tag == "non-Proof") // Proof랑 충돌했을 때는 실행되면 안된다.
            {
                collidedObjectName = nearObject.gameObject.name; //충돌한 오브젝트 이름 저장
                Debug.Log(collidedObjectName); // 오브젝트 이름 출력 (tag가 아님)
                    Destroy(nearObject);
                    // isDestroy를 true로 만들고 Proof 스크립트에서 처리
                    Conversation.SetActive(true); //대화창이 떴고 Conversation 스크립트 진행하고 대화 끝나면 Conversation.SetActive를 false로 Conversation 스크립트에서 조정
                    GetComponent<pickUpItem>().print();//대화창

            }

            if (nearObject.tag == "another")
            {
                collidedObjectName = nearObject.gameObject.name; //충돌한 오브젝트 이름 저장
                Debug.Log(collidedObjectName); // 오브젝트 이름 출력 (tag가 아님)

                    Debug.Log("실행");
                    Conversation.SetActive(true); //대화창이 떴고 Conversation 스크립트 진행하고 대화 끝나면 Conversation.SetActive를 false로 Conversation 스크립트에서 조정
                    GetComponent<pickUpItem>().print();
            }
            nearObject = null;
        }
    }
}