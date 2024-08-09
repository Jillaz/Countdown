using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countdownText;
    [SerializeField] private Counter _counterTik;
    [SerializeField] private int _startValue = 0;

    private void Start()
    {
        _countdownText.text = _startValue.ToString();
    }

    private void OnEnable()
    {
        _counterTik.Tick += Display;
    }

    private void OnDisable()
    {
        _counterTik.Tick -= Display;
    }

    private void Display()
    {
        _startValue++;
        _countdownText.text = _startValue.ToString();
    }
}
