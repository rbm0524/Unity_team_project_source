using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Vector3 previousPosition;
    private Vector3 initialPosition;
    private float playerRadius;

    private void Start()
    {
        // Player의 초기 위치를 저장한다.
        initialPosition = transform.position;
        previousPosition = initialPosition;

        // Player 오브젝트의 캡슐형 콜라이더의 반지름을 계산한다.
        playerRadius = CalculatePlayerRadius() + 0.1f;
    }

    private void FixedUpdate()
    {
        // 이전 프레임의 위치와 현재 위치를 비교하여 충돌이 발생했는지 확인한다.
        if (transform.position != previousPosition)
        {
            Vector3 movementDirection = (transform.position - previousPosition).normalized;
            float movementDistance = Vector3.Distance(previousPosition, transform.position);

            // Player 위치를 기준으로 반지름이 playerRadius인 원을 그린다.
            Vector3 centerPosition = transform.position;
            float radius = playerRadius;

            // Player 위치와 반지름을 기준으로 충돌 검사를 수행한다.
            Collider[] colliders = Physics.OverlapSphere(centerPosition, radius);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject != gameObject && collider.gameObject.name != "colliderObject")
                {
                    // 충돌이 발생한 경우 충돌이 되기 직전의 위치로 이동한다.
                    transform.position = previousPosition;
                    break;
                }
            }
        }

        // 현재 위치를 이전 프레임의 위치로 저장한다.
        previousPosition = transform.position;
    }

    private float CalculatePlayerRadius()
    {
        // Player 오브젝트의 캡슐형 콜라이더 컴포넌트를 가져온다.
        CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
        if (capsuleCollider != null)
        {
            // 캡슐형 콜라이더의 반지름을 계산하여 반환한다.
            float radius = Mathf.Max(capsuleCollider.radius * transform.lossyScale.x, capsuleCollider.radius * transform.lossyScale.z);
            return radius;
        }

        // 기본값으로 0.5f를 반환한다.
        return 0.5f;
    }
}
