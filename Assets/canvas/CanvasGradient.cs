using UnityEngine;
using UnityEngine.UI;

public class CanvasGradient : MonoBehaviour
{
    private float radius; // ������
    public Color darkColor = Color.black; // ��ο� ����

    private RawImage canvasImage; // ĵ������ RawImage ������Ʈ

    private void Start()
    {
        radius = 20f;
        canvasImage = GetComponent<RawImage>();

        if (canvasImage != null)
        {
            canvasImage.material = new Material(Shader.Find("UI/Default")); // �⺻ UI ���̴� ���
        }
        else
        {
            Debug.LogError("RawImage ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }

    private void Update()
    {
        if (canvasImage != null)
        {
            // ĵ������ �߽� ��ġ
            Vector2 canvasCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

            // ���� �÷��̾��� ��ġ
            Vector3 playerPosition = Camera.main.WorldToScreenPoint(transform.position);

            // �÷��̾�� ĵ���� �߽� ������ �Ÿ� ���
            float distance = Vector2.Distance(canvasCenter, playerPosition);

            // ��ο����� ���� ���
            float darkness = Mathf.Clamp01((distance - radius) / (radius * 0.5f)); // �������� �������� ��ο��� �ִ� �Ÿ��� ����

            // ��ο� ���� ����
            Color targetColor = Color.Lerp(Color.white, darkColor, darkness);
            canvasImage.material.color = targetColor;
        }
    }
}

