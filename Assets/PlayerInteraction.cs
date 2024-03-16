using UnityEngine;
//���� ����
public class PlayerInteraction : MonoBehaviour
{
    private Color originalColor;
    private GameObject highlightedObject;
    private Material originalMaterial;

    public Shader outlineShader; // �׵θ� ���̴�
    public Color outlineColor = Color.green; // �׵θ� ����


    private void Start()
    {
        originalColor = Color.white;
    }

    private void Update()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);  //canvas�� �߾� ����
        Ray ray = Camera.main.ScreenPointToRay(screenCenter); //Raycast�� �̿��� canvas�� �߾��������� ���.
        RaycastHit hit;

        if (highlightedObject != null)
        {
            // �׵θ� ������ ���� ���·� �����Ѵ�.
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

            // �÷��̾� ��ġ�� ��ü ������ �Ÿ�
            float playerDist = Vector3.Distance(hitObject.transform.position, transform.position);

            // �±װ� "Proof"�� "non-Proof"�� ������Ʈ�� �������� �� �׵θ� ������ ����.
            if ((hitObject.CompareTag("Proof") || hitObject.CompareTag("non-Proof") || hitObject.CompareTag("another")) && playerDist <= 3f)
            {
                Renderer renderer = hitObject.GetComponent<Renderer>();
                if (renderer != null)
                {
                    // ���� ��Ƽ������ ����
                    originalMaterial = renderer.material;

                    // ���ο� ��Ƽ������ �����Ͽ� �׵θ� ������ ����
                    Material outlineMaterial = new Material(outlineShader);
                    outlineMaterial.SetColor("_OutlineColor", outlineColor);

                    // ��ü�� ��Ƽ������ ����
                    renderer.material = outlineMaterial;
                    renderer.material.color = originalColor;

                    highlightedObject = hitObject;
                }
            }
        }
    }

    private void OnDestroy()
    {
        // ��ũ��Ʈ�� ������ �� ������ ��Ƽ������ ����
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