using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;    

    protected float _currentHealthPercentage = 100;
    protected float _maximalHealthPercentage = 100;

    [SerializeField] private Camera _mainCamera;

    private void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + _mainCamera.transform.forward);
    }

    protected abstract void OnHealthChanged(int currentValue);
}
