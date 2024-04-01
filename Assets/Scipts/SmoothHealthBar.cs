using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : HealthBar
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private int _barChangingSpeed;

    private float _fillPercentage = 100;

    private void Update()
    {
        _fillPercentage = Mathf.MoveTowards(_fillPercentage, _currentHealthPercentage, _barChangingSpeed * Time.deltaTime);
        _healthBar.value = _fillPercentage;
    }

    protected override void OnHealthChanged(int currentValue)
    { 
        _currentHealthPercentage = currentValue * 100 / _health.MaximalValue;
    }
}
