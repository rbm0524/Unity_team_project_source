using UnityEngine;
//색상 조정
public class PlayerInteraction : MonoBehaviour
{
    private Color originalColor;
    private GameObject highlightedObject;
    private Material originalMaterial;

    public Shader outlineShader; // 테두리 쉐이더
    public Color outlineColor = Color.green; // 테두리 색상


    private void Start()
    {
        originalColor = Color.white;
    }

    private void Update()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);  //canvas의 중앙 지점
        Ray ray = Camera.main.ScreenPointToRay(screenCenter); //Raycast를 이용해 canvas의 중앙지점에서 쏜다.
        RaycastHit hit;

        if (highlightedObject != null)
        {
            // 테두리 색상을 원래 상태로 복원한다.
            Renderer renderer = highlightedObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.shader = Shader.Find("Standard");
                renderer.material.color = originalColor;
            }

            highlightedObject = null;
        }

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            // 플레이어 위치와 물체 사이의 거리
            float playerDist = Vector3.Distance(hitObject.transform.position, transform.position);

            // 태그가 "Proof"나 "non-Proof"인 오브젝트에 접근했을 때 테두리 색상을 변경.
            if ((hitObject.CompareTag("Proof") || hitObject.CompareTag("non-Proof") || hitObject.CompareTag("another")) && playerDist <= 3f)
            {
                Renderer renderer = hitObject.GetComponent<Renderer>();
                if (renderer != null)
                {
                    // 원래 머티리얼을 저장
                    originalMaterial = renderer.material;

                    // 새로운 머티리얼을 생성하여 테두리 색상을 설정
                    Material outlineMaterial = new Material(outlineShader);
                    outlineMaterial.SetColor("_OutlineColor", outlineColor);

                    // 물체의 머티리얼을 변경
                    renderer.material = outlineMaterial;
                    renderer.material.color = originalColor;

                    highlightedObject = hitObject;
                }
            }
        }
    }

    private void OnDestroy()
    {
        // 스크립트가 삭제될 때 원래의 머티리얼을 복원
        if (highlightedObject != null && originalMaterial != null)
        {
            Renderer renderer = highlightedObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = originalMaterial;
                renderer.material.color = originalColor;
            }
        }
    }
}