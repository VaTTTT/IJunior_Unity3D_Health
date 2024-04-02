using UnityEngine;
using UnityEngine.UI;

public class StandardHealthBar : HealthBar
{
    [SerializeField] private Slider _healthSlider;

    protected override void OnHealthChanged(int currentValue)
    {
        if (_healthSlider != null)
        {
            _healthSlider.value = currentValue * 100 / Health.MaximalValue;
        }
    }
}
