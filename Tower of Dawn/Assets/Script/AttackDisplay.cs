using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttackDisplay : MonoBehaviour
{
    public Button attackButton;
    public TMP_Text attackText;

    public string attackName = "Player 1 used Fireball"; // Replace with your desired attack name

    void Start()
    {
        attackButton.onClick.AddListener(DisplayAttackName);
    }

    void DisplayAttackName()
    {
        attackText.text = attackName;
    }
}