using TMPro;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countdownText;
    [SerializeField] private Counter _counter;

    private void Start()
    {
        _countdownText.text = _counter.CounterValue.ToString();
    }

    private void OnEnable()
    {
        _counter.Tick += Display;
    }

    private void OnDisable()
    {
        _counter.Tick -= Display;
    }

    private void Display()
    {
        _countdownText.text = _counter.CounterValue.ToString();
    }
}
