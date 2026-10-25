using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField] private float range = 5f;
    [SerializeField] private float rotationSpeed = 5f;

    private void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        Transform nearest = null;
        float nearestDistance = range;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);

            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearest = enemy.transform;
            }
        }

        if (nearest != null)
        {
            Vector2 direction = nearest.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            Quaternion Qn = Quaternion.Euler(0f, 0f, angle);

            transform.rotation = Quaternion.Slerp(transform.rotation, Qn, rotationSpeed * Time.deltaTime);
        }
    }
}
