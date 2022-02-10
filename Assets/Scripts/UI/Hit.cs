using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _damageValue = 10;

    public void Attack()
    {
        if (_player.Health != 0)
            _player.Damage(_damageValue);
    }
}
