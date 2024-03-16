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
        panelImage.color = Color.black; // ������ �гη� ����
        fadeSpeed = 3f / fadeDuration; // ���̵� �ӵ� ���
    }

    private void Update()
    {
        // �ð��� �带���� �г��� ������ ���ҽ�Ŵ
        currentAlpha -= fadeSpeed * Time.deltaTime;

        // �г��� ������ 0 ���Ϸ� �������� ���� ȭ���� ������
        if (currentAlpha <= 0f)
        {
            panelImage.gameObject.SetActive(false); // �г� ��Ȱ��ȭ
            enabled = false; // ��ũ��Ʈ ��Ȱ��ȭ
        }

        // �г��� ���� ������Ʈ
        Color panelColor = panelImage.color;
        panelColor.a = currentAlpha;
        panelImage.color = panelColor;
    }
}
