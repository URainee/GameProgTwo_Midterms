using UnityEngine;

public class AutoShooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePosition;
    [SerializeField] private float reloadInterval = 1f;

    private float timer;
    private PlayerColorSwitch playerColorSwitch;

    private void Awake()
    {
        playerColorSwitch = GetComponent<PlayerColorSwitch>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= reloadInterval)
        {
            Shoot();
            timer -= reloadInterval;
        }

        if (Input.GetMouseButtonDown(0))
            ChangeColor();
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation);

        PlayerColor color = playerColorSwitch.currentColor;

        newBullet.GetComponent<BulletColorSwitch>().TakeDamage(color);
        newBullet.GetComponent<Bullet>().SetColor(color);
    }

    private void ChangeColor()
    {
        if (playerColorSwitch != null)
            playerColorSwitch.Switch(gameObject);
    }
}
