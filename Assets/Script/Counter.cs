using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    [SerializeField] private MouseClicker _mouseClicker;    
    [SerializeField] private float _delay = 0.5f;

    public event UnityAction Tick;
    private Coroutine _coroutine;
    private bool _isCoroutinePlaying = false;

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
            StopCoroutine(_coroutine);
            _isCoroutinePlaying = false;
        }
    }

    private IEnumerator IncreaseCountdown()
    {
        var wait = new WaitForSeconds(_delay);

        while (true)
        {
            Tick?.Invoke();
            yield return wait;
        }
    }
}
