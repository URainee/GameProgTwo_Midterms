using UnityEngine;

public class Enemy : EnemyBase, IDamageable
{
    [SerializeField]private PlayerColor enemyColor;

    public void TakeDamage(PlayerColor bulletColor)
    {
        Debug.Log($"Bullet: {bulletColor}, Enemy: {enemyColor}");
        if (bulletColor == enemyColor)
        {
            Destroy(gameObject);
        }
    }
}
