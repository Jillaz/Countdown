using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countdownText;

    public void Display (string text)
    {
        _countdownText.text = text;
    }
}
