using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{

    public float Health { get; private set; } = 50;
    public float MinHealth { get; private set; } = 0;
    public float MaxHealth { get; private set; } = 100;

    public event UnityAction HealthChanged;

    public void Heal(float healValue)
    {
        if (IsUpperLimitHealth() == false)
        {
            if (healValue >= MaxHealth)
                healValue = MaxHealth;

            Health += healValue;
            HealthChanged?.Invoke();
        }
    }

    public void Damage(float damageValue)
    {
        if (IsLowerLimitHealth() == false && damageValue <= Health)
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