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

    public float movementSpeed; // �̵� �ӵ� ����
    public float mouseSensitivity = 2f; // ���콺 ���� ����
    private float rotationX = 0f;
    private Inventory inventory;
    public GameObject ruminol_active1;//�ξ�Į
    public GameObject ruminol_active2; //�Ž� �ٴ�
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
        // Awake �޼��� ������ FindObjectsOfType �Լ� ȣ��
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
        Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ���� ȭ�� �ȿ� ����
        Cursor.visible = false; // ���콺 Ŀ���� ������ �ʰ� ����
    }

    private void HandleMovement()
    {
        // �÷��̾� �̵� ó��
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * movementSpeed  * Time.deltaTime;
        transform.Translate(movement);
    }

    private void HandleMouseLook()
    {
        // ���콺 ���� ���� ó��
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // �¿� ȸ��
        transform.Rotate(Vector3.up * mouseX);

        // ���� ȸ��
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
        Getitem = Input.GetButtonDown("Get"); // f�� �Է� �� Getitem�� true input manager���� Get�̶� �̸����� �ϳ� ���� positive key �Է�
    }

    void Get()
    {
        if (Getitem && nearObject != null) // Getitem�� true�̰� nearObject�� not null�� ��
        {
            if (nearObject.tag == "Proof") // �浹�� ���� tag�� Proof�� ����
            {
                collidedObjectName = nearObject.gameObject.name; //�浹�� ������Ʈ �̸� ����
                Debug.Log(collidedObjectName); // ������Ʈ �̸� ��� (tag�� �ƴ�)
                    Destroy(nearObject);
                    // isDestroy�� true�� ����� Proof ��ũ��Ʈ���� ó��
                    Conversation.SetActive(true); //��ȭâ�� ���� Conversation ��ũ��Ʈ �����ϰ� ��ȭ ������ Conversation.SetActive�� false�� Conversation ��ũ��Ʈ���� ����
                    GetComponent<pickUpItem>().print();

            }

            if (nearObject.tag == "non-Proof") // Proof�� �浹���� ���� ����Ǹ� �ȵȴ�.
            {
                collidedObjectName = nearObject.gameObject.name; //�浹�� ������Ʈ �̸� ����
                Debug.Log(collidedObjectName); // ������Ʈ �̸� ��� (tag�� �ƴ�)
                    Destroy(nearObject);
                    // isDestroy�� true�� ����� Proof ��ũ��Ʈ���� ó��
                    Conversation.SetActive(true); //��ȭâ�� ���� Conversation ��ũ��Ʈ �����ϰ� ��ȭ ������ Conversation.SetActive�� false�� Conversation ��ũ��Ʈ���� ����
                    GetComponent<pickUpItem>().print();//��ȭâ

            }

            if (nearObject.tag == "another")
            {
                collidedObjectName = nearObject.gameObject.name; //�浹�� ������Ʈ �̸� ����
                Debug.Log(collidedObjectName); // ������Ʈ �̸� ��� (tag�� �ƴ�)

                    Debug.Log("����");
                    Conversation.SetActive(true); //��ȭâ�� ���� Conversation ��ũ��Ʈ �����ϰ� ��ȭ ������ Conversation.SetActive�� false�� Conversation ��ũ��Ʈ���� ����
                    GetComponent<pickUpItem>().print();
            }
            nearObject = null;
        }
    }
}