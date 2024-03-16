using UnityEngine;
using UnityEngine.UI;

public class CanvasGradient : MonoBehaviour
{
    private float radius; // 반지름
    public Color darkColor = Color.black; // 어두운 색상

    private RawImage canvasImage; // 캔버스의 RawImage 컴포넌트

    private void Start()
    {
        radius = 20f;
        canvasImage = GetComponent<RawImage>();

        if (canvasImage != null)
        {
            canvasImage.material = new Material(Shader.Find("UI/Default")); // 기본 UI 셰이더 사용
        }
        else
        {
            Debug.LogError("RawImage 컴포넌트를 찾을 수 없습니다.");
        }
    }

    private void Update()
    {
        if (canvasImage != null)
        {
            // 캔버스의 중심 위치
            Vector2 canvasCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);

            // 현재 플레이어의 위치
            Vector3 playerPosition = Camera.main.WorldToScreenPoint(transform.position);

            // 플레이어와 캔버스 중심 사이의 거리 계산
            float distance = Vector2.Distance(canvasCenter, playerPosition);

            // 어두워지는 정도 계산
            float darkness = Mathf.Clamp01((distance - radius) / (radius * 0.5f)); // 반지름을 기준으로 어두워질 최대 거리를 설정

            // 어두운 색상 적용
            Color targetColor = Color.Lerp(Color.white, darkColor, darkness);
            canvasImage.material.color = targetColor;
        }
    }
}

