using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _damageValue = 10;

    private void Attack()
    {
        _player.Damage(_damageValue);
    }
}