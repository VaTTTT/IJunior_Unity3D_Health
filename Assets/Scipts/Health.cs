using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maximalValue;
    
    private int _currentValue;

    public event UnityAction<int> Changed;

    public int MaximalValue => _maximalValue;

    private void Start()
    {
        _currentValue = _maximalValue;
    }

    public void ApplyDamage(int damage)
    {
        _currentValue = Mathf.Clamp(_currentValue - damage, 0, _maximalValue);

        Changed?.Invoke(_currentValue);
    }

    public void ApplyHealing(int amount)
    {
        _currentValue = Mathf.Clamp(_currentValue + amount, 0, _maximalValue);

        Changed?.Invoke(_currentValue);
    }
}
