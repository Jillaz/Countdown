using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countdownText;
    [SerializeField] private MouseClicker _mouseClicker;
    [SerializeField] private int _startValue = 0;
    [SerializeField] private float _delay = 0.5f;

    private IEnumerator _coroutine;
    private bool _isCoroutinePlaying = false;

    void Start()
    {
        _countdownText.text = _startValue.ToString();
        _coroutine = IncreaseCountdown();
    }

    private void OnEnable()
    {
        _mouseClicker.MouseButtonClick += CoroutineSwitcher;
    }

    private void OnDisable()
    {
        _mouseClicker.MouseButtonClick -= CoroutineSwitcher;
    }

    private void CoroutineSwitcher()
    {
        if (_isCoroutinePlaying == false)
        {
            StartCoroutine(_coroutine);
            _isCoroutinePlaying = true;
        }
        else
        {
            StopCoroutine(_coroutine);
            _isCoroutinePlaying = false;
        }
    }

    private IEnumerator IncreaseCountdown()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            _startValue++;
            _countdownText.text = _startValue.ToString();

            yield return wait;
        }
    }
}
