using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    [SerializeField] protected float speed = 1.5f;
    [SerializeField] private string playerTag = "Player";

    protected virtual void Update()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag(playerTag);

        GameObject nearestPlayer = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject target in players)
        {
            float distance = Vector2.Distance(transform.position, target.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                nearestPlayer = target;
            }
        }

        if (nearestPlayer == null) return;

        transform.position = Vector2.MoveTowards( transform.position, nearestPlayer.transform.position, speed * Time.deltaTime);
    }
}