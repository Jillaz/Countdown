using UnityEngine;
using UnityEngine.Events;

public class MouseClicker : MonoBehaviour
{
    public event UnityAction MouseButtonClick;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseButtonClick?.Invoke();
        }
    }
}
