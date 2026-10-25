using UnityEngine;

public class PlayerColorSwitch : MonoBehaviour, ISwitchable
{
    [SerializeField] private SpriteRenderer sr;

    public PlayerColor currentColor { get; private set;  } = PlayerColor.Red;

    private void Start()
    {
        UpdateColor();
    }

    public void Switch(GameObject interactor)
    {
        if (currentColor == PlayerColor.Red)
        {
            currentColor = PlayerColor.Green;
        }
        else if (currentColor == PlayerColor.Green)
        {
            currentColor = PlayerColor.Blue;
        }
        else if (currentColor == PlayerColor.Blue)
        {
            currentColor = PlayerColor.Yellow;
        }
        else
        {
            currentColor = PlayerColor.Red;
        }

        UpdateColor();
    }

    private void UpdateColor()
    {
        if (currentColor == PlayerColor.Red)
        {
            sr.color = Color.red;
        }
        else if (currentColor == PlayerColor.Green)
        {
            sr.color = Color.green;
        }
        else if (currentColor == PlayerColor.Blue)
        {
            sr.color = Color.blue;
        }
        else
        {
            sr.color = Color.yellow;
        }
    }
}
