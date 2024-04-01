using TMPro;
using UnityEngine;

public class TextHealthBar : HealthBar
{
    [SerializeField] private TextMeshProUGUI _textField;

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
        _textField.text = _currentHealthPercentage + " / " + _maximalHealthPercentage;
    }

    protected override void OnHealthChanged(int currentValue)
    {
        _currentHealthPercentage = currentValue * 100 / _health.MaximalValue;

        if (_textField != null)
        {
            _textField.text = _currentHealthPercentage + " / " + _maximalHealthPercentage;

            if (_currentHealthPercentage <= 0)
            {
                _textField.text = "DEAD";
            }
        }
    }
}
