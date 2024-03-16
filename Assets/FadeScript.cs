using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour

{
    public Image panelImage;
    public float fadeDuration = 3f;

    private float currentAlpha = 3f;
    private float fadeSpeed;

    private void Start()
    {
        panelImage.color = Color.black; // 검정색 패널로 설정
        fadeSpeed = 3f / fadeDuration; // 페이드 속도 계산
    }

    private void Update()
    {
        // 시간이 흐를수록 패널의 투명도를 감소시킴
        currentAlpha -= fadeSpeed * Time.deltaTime;

        // 패널의 투명도가 0 이하로 내려가면 게임 화면을 보여줌
        if (currentAlpha <= 0f)
        {
            panelImage.gameObject.SetActive(false); // 패널 비활성화
            enabled = false; // 스크립트 비활성화
        }

        // 패널의 투명도 업데이트
        Color panelColor = panelImage.color;
        panelColor.a = currentAlpha;
        panelImage.color = panelColor;
    }
}
