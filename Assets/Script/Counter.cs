using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private MouseClicker _mouseClicker;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private int _startValue = 0;
    private bool _isCoroutinePlaying = false;
    private Coroutine _coroutine;

    public event UnityAction Tick;

    public int CounterValue => _startValue;

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
            _coroutine = StartCoroutine(IncreaseCountdown());
            _isCoroutinePlaying = true;
        }
        else
        {
            if (_coroutine != null)
            {
                StopCoroutine(_coroutine);
            }

            _isCoroutinePlaying = false;
        }
    }

    private IEnumerator IncreaseCountdown()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            _startValue++;
            Tick?.Invoke();
            yield return wait;
        }
    }
}
