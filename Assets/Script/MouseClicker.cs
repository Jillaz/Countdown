using UnityEngine;
using UnityEngine.Events;

public class MouseClicker : MonoBehaviour
{
    private int _mouseLeftButton = 0;
    public event UnityAction MouseButtonClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseLeftButton))
        {
            MouseButtonClick?.Invoke();
        }
    }
}
