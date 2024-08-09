using UnityEngine;
using UnityEngine.Events;

public class MouseClicker : MonoBehaviour
{
    public event UnityAction MouseButtonClick;
    private int _mouseLeftButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseLeftButton))
        {
            MouseButtonClick?.Invoke();
        }
    }
}
