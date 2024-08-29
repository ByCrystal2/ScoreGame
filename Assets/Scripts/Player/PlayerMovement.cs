using UnityEngine;
[RequireComponent (typeof(ClickHolder),typeof(PlayerUIHandler))]
public class PlayerMovement : MonoBehaviour
{
    public float CurrentShootValue;
    public float MaxShootValue;
    [Range(0,10f)] public float ShootPowerRate;
    ClickHolder ClickHolder;
    PlayerUIHandler uIHandler;
    private void Awake()
    {
        ClickHolder = GetComponent<ClickHolder>();
        uIHandler = GetComponent<PlayerUIHandler>();
    }
    private void OnEnable()
    {
        ClickHolder.OnClick += IncreaseKickPower;
        ClickHolder.OnClickUp += ResetValues;
    }
    private void OnDisable()
    {
        ClickHolder.OnClick -= IncreaseKickPower;
        ClickHolder.OnClickUp -= ResetValues;
    }
    public void IncreaseKickPower()
    {
        SetCurrentShootValue(ShootPowerRate);
    }
    public void ResetValues()
    {
        CurrentShootValue = 0;
    }
    private void SetCurrentShootValue(float value)
    {
        if (CurrentShootValue + value > MaxShootValue) { CurrentShootValue = MaxShootValue; Debug.Log("Son guce ulasildi..."); return; }
        CurrentShootValue += value;
        uIHandler.ActiveBar(true);
        uIHandler.SetSliderValue(Mathf.Clamp(CurrentShootValue / MaxShootValue, 0, 1));
    }
}
