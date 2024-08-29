using UnityEngine;

public class ClickHolder : MonoBehaviour
{
    public delegate void OnClickHandler(bool _query = false);
    public event OnClickHandler OnClick;
    public event OnClickHandler OnClickDown;
    public event OnClickHandler OnClickUp;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClickDown?.Invoke();
        }
        if (Input.GetMouseButton(0))
        {
            OnClick?.Invoke();
        }
        if (Input.GetMouseButtonUp(0))
        {
            OnClickUp?.Invoke();
        }
    }
}
