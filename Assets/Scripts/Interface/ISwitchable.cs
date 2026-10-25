using UnityEngine;

public enum PlayerColor
{ 
    Red,
    Green,
    Blue,
    Yellow
}

public interface ISwitchable
{
    void Switch(GameObject interactor);
}

