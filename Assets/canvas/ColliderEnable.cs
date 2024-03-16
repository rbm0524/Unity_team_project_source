using UnityEngine;

public class ColliderEnable : MonoBehaviour
{
    private Collider lastHitCollider; // �ֱٿ� �浹�� �ݶ��̴��� �����ϴ� ����

    private void Update()
    {
        // Raycast
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            // ���� ��ü�� �ݶ��̴��� �����´�.
            Collider hitCollider = hit.collider;

            // �ֱٿ� �浹�� �ݶ��̴��� null�� �ƴϰ� ���� �浹�� �ݶ��̴��� �ٸ� ���, �ش� �ݶ��̴��� ��Ȱ��ȭ�Ѵ�.
            if (lastHitCollider != null && lastHitCollider != hitCollider)
            {
                lastHitCollider.enabled = false;
            }

            float playerDist = Vector3.Distance(hitObject.transform.position, transform.position);

            // ���� ��ü���� �Ÿ��� 1.2f ������ ���
            if (playerDist <= 3f)
            {
                // ���� ��ü�� �ڽ� ������Ʈ �� colliderObject �̸��� ���� ������Ʈ�� Collider�� Ȱ��ȭ
                Transform colliderObject = hitObject.transform.Find("colliderObject");
                if (colliderObject != null)
                {
                    Collider collider = colliderObject.GetComponent<Collider>();
                    if (collider != null)
                    {
                        collider.enabled = true;
                        lastHitCollider = collider; // �ֱٿ� �浹�� �ݶ��̴��� �����Ѵ�.
                    }
                }
            }
            else
            {
                // 0,0,0���� ����� �ֱٿ� �浹�� �ݶ��̴��� ��Ȱ��ȭ�Ѵ�.
                if (lastHitCollider != null)
                {
                    lastHitCollider.enabled = false;

                    // nearObject�� null�� �ʱ�ȭ�Ѵ�.
                    Player playerScript = GetComponent<Player>();
                    if (playerScript != null)
                    {
                        playerScript.nearObject = null;
                    }
                }

            }
        }
    }
}
