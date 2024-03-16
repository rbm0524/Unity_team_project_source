using UnityEngine;

public class ColliderEnable : MonoBehaviour
{
    private Collider lastHitCollider; // 최근에 충돌한 콜라이더를 저장하는 변수

    private void Update()
    {
        // Raycast
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            // 맞은 물체의 콜라이더를 가져온다.
            Collider hitCollider = hit.collider;

            // 최근에 충돌한 콜라이더가 null이 아니고 현재 충돌한 콜라이더와 다른 경우, 해당 콜라이더를 비활성화한다.
            if (lastHitCollider != null && lastHitCollider != hitCollider)
            {
                lastHitCollider.enabled = false;
            }

            float playerDist = Vector3.Distance(hitObject.transform.position, transform.position);

            // 맞은 물체와의 거리가 1.2f 이하인 경우
            if (playerDist <= 3f)
            {
                // 맞은 물체의 자식 오브젝트 중 colliderObject 이름을 가진 오브젝트의 Collider를 활성화
                Transform colliderObject = hitObject.transform.Find("colliderObject");
                if (colliderObject != null)
                {
                    Collider collider = colliderObject.GetComponent<Collider>();
                    if (collider != null)
                    {
                        collider.enabled = true;
                        lastHitCollider = collider; // 최근에 충돌한 콜라이더를 저장한다.
                    }
                }
            }
            else
            {
                // 0,0,0에서 벗어나면 최근에 충돌한 콜라이더를 비활성화한다.
                if (lastHitCollider != null)
                {
                    lastHitCollider.enabled = false;

                    // nearObject를 null로 초기화한다.
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
