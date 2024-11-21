using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AttackDisplay : MonoBehaviour
{
    public Button attackButton;
    public TypewriterEffect attackText;

    public string attackName = "Player 1 used Fireball"; // Replace with your desired attack name

    void Start()
    {
        attackButton.onClick.AddListener(DisplayAttackName);
        this.gameObject.SetActive(false);
    }

    void DisplayAttackName()
    {
        attackText.Typewriter(attackName);
        Debug.Log("Attack Missed");
    }
}