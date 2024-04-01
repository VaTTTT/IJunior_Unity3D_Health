using UnityEngine;
using UnityEngine.UI;

public class StandardHealthBar : HealthBar
{
    [SerializeField] private Slider _healthBar;

    protected override void OnHealthChanged(int currentValue)
    {
        _currentHealthPercentage = currentValue * 100 / _health.MaximalValue;

        if (_healthBar != null)
        {
            _healthBar.value = _currentHealthPercentage;
        }
    }
}
