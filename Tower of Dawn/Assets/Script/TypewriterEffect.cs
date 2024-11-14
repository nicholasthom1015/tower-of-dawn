using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{
    public TMP_Text textComponent;
    public float typingSpeed = 0.05f;
    private string fullText;
    private int currentCharIndex;

    void Start()
    {
        fullText = textComponent.text;
        textComponent.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char c in fullText)
        {
            textComponent.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}