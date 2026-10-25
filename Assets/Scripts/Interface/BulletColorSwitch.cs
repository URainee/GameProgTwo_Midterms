using UnityEngine;

public class BulletColorSwitch : MonoBehaviour, IDamageable
{

    [SerializeField] private SpriteRenderer sr;

    public PlayerColor CurrentColor {get; private set;}
    public void TakeDamage(PlayerColor bulletColor)
    {

        if (bulletColor == PlayerColor.Red)
            sr.color = Color.red;
        else if (bulletColor == PlayerColor.Green)
            sr.color = Color.green;
        else if (bulletColor == PlayerColor.Blue)
            sr.color = Color.blue;
        else
            sr.color = Color.yellow;
    }
}
