using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float Health { get; private set; } = 50;

    public void Heal(float healValue)
    {
        Health += healValue;
    }

    public void Damage(float damageValue)
    {
        Health -= damageValue;
    }
}