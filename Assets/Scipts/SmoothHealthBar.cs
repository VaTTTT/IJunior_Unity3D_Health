using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : HealthBar
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private int _barChangingSpeed;

    private float _currentFillPercentage = 100;
    private int _currentHealthPercentage = 100;

    private void Update()
    {
        _currentFillPercentage = Mathf.MoveTowards(_currentFillPercentage, _currentHealthPercentage, _barChangingSpeed * Time.deltaTime);
        _healthSlider.value = _currentFillPercentage;
    }

    protected override void OnHealthChanged(int currentValue)
    { 
        _currentHealthPercentage = currentValue * 100 / Health.MaximalValue;
    }
}
