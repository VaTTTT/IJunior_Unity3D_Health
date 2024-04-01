using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maximalValue;
    
    private int _currentValue;

    public event UnityAction<int> HealthChanged;

    public int MaximalValue => _maximalValue;
    public int CurrentValue => _currentValue;

    private void Start()
    {
        _currentValue = _maximalValue;
    }

    public void ApplyDamage(int damage)
    {
        _currentValue = Mathf.Clamp(_currentValue - damage, 0, _maximalValue);

        HealthChanged?.Invoke(_currentValue);

        if (_currentValue == 0)
        {
            Destroy(gameObject);
        }
    }

    public void ApplyHealing(int amount)
    {
        _currentValue = Mathf.Clamp(_currentValue + amount, 0, _maximalValue);

        HealthChanged?.Invoke(_currentValue);
    }
}
