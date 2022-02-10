using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityAction HealthChanged;

    public float Health { get; private set; } = 50;
    public float MinHealth { get; private set; } = 0;
    public float MaxHealth { get; private set; } = 100;

    public void Heal(float healValue)
    {
        if (IsUpperLimitHealth() == false)
        {
            Health += healValue;
            HealthChanged?.Invoke();
        }
    }

    public void Damage(float damageValue)
    {
        if (IsLowerLimitHealth() == false)
        {
            Health -= damageValue;
            HealthChanged?.Invoke();
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