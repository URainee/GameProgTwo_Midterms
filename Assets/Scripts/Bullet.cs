using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] public float speed = 10f;

    private PlayerColor bulletColor;
    public PlayerColor Color => bulletColor;

    public void SetColor(PlayerColor color)
    {
        bulletColor = color;
    }

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        IDamageable damageable = collide.GetComponentInParent<IDamageable>();

        if (damageable == null)
            return;

        damageable.TakeDamage(Color);
        Destroy(gameObject);
    }
}
