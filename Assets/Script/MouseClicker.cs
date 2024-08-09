using UnityEngine;
using UnityEngine.Events;

public class MouseClicker : MonoBehaviour
{
    public event UnityAction MouseButtonClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseButtonClick?.Invoke();
        }
    }
}
