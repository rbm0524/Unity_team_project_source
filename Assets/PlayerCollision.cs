using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Vector3 previousPosition;
    private Vector3 initialPosition;
    private float playerRadius;

    private void Start()
    {
        // Player�� �ʱ� ��ġ�� �����Ѵ�.
        initialPosition = transform.position;
        previousPosition = initialPosition;

        // Player ������Ʈ�� ĸ���� �ݶ��̴��� �������� ����Ѵ�.
        playerRadius = CalculatePlayerRadius() + 0.1f;
    }

    private void FixedUpdate()
    {
        // ���� �������� ��ġ�� ���� ��ġ�� ���Ͽ� �浹�� �߻��ߴ��� Ȯ���Ѵ�.
        if (transform.position != previousPosition)
        {
            Vector3 movementDirection = (transform.position - previousPosition).normalized;
            float movementDistance = Vector3.Distance(previousPosition, transform.position);

            // Player ��ġ�� �������� �������� playerRadius�� ���� �׸���.
            Vector3 centerPosition = transform.position;
            float radius = playerRadius;

            // Player ��ġ�� �������� �������� �浹 �˻縦 �����Ѵ�.
            Collider[] colliders = Physics.OverlapSphere(centerPosition, radius);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject != gameObject && collider.gameObject.name != "colliderObject")
                {
                    // �浹�� �߻��� ��� �浹�� �Ǳ� ������ ��ġ�� �̵��Ѵ�.
                    transform.position = previousPosition;
                    break;
                }
            }
        }

        // ���� ��ġ�� ���� �������� ��ġ�� �����Ѵ�.
        previousPosition = transform.position;
    }

    private float CalculatePlayerRadius()
    {
        // Player ������Ʈ�� ĸ���� �ݶ��̴� ������Ʈ�� �����´�.
        CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
        if (capsuleCollider != null)
        {
            // ĸ���� �ݶ��̴��� �������� ����Ͽ� ��ȯ�Ѵ�.
            float radius = Mathf.Max(capsuleCollider.radius * transform.lossyScale.x, capsuleCollider.radius * transform.lossyScale.z);
            return radius;
        }

        // �⺻������ 0.5f�� ��ȯ�Ѵ�.
        return 0.5f;
    }
}
