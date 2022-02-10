using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _healValue = 10;

    public void Heal()
    {
        if (_player.Health != 100)
            _player.Heal(_healValue);
    }
}
