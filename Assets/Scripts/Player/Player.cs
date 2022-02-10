using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityAction _healthChanged;

    public float Health { get; private set; } = 50;

    private const float MinHealth = 0;
    private const float MaxHealth = 100;

    public event UnityAction HealthChanged
    {
        add => _healthChanged += value;
        remove => _healthChanged -= value;
    }

    public void Heal(float healValue)
    {
        if (IsUpperLimitHealth() == false)
        {
            Health += healValue;
            _healthChanged?.Invoke();
        }
    }

    public void Damage(float damageValue)
    {
        if (IsLowerLimitHealth() == false)
        {
            Health -= damageValue;
            _healthChanged?.Invoke();
        }
    }

    private bool IsUpperLimitHealth()
    {
        return Health == MaxHealth;
    }

    private bool IsLowerLimitHealth()
    {
        return Health == MinHealth;
    }
}