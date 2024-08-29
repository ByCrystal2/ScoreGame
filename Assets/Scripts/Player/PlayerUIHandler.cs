using UnityEngine;
using UnityEngine.UI;

public class PlayerUIHandler : MonoBehaviour
{
    [SerializeField] Slider m_Bar;
    ClickHolder m_ClickHolder;
    private void Awake()
    {
        m_ClickHolder = GetComponent<ClickHolder>();
    }
    private void OnEnable()
    {
        //m_ClickHolder.OnClick += ActiveBar(true);
        //En son burada kalmistik devam edecegiz...
    }
    private void OnDisable()
    {
        
    }
    public void SetSliderValue(float _value)
    {
        m_Bar.value = _value;
    }
    public void ActiveBar(bool _active)
    {
        if (m_Bar.gameObject.activeSelf != _active)
        m_Bar.gameObject.SetActive(_active);
    }
}
