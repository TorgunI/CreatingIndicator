using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerHealthSlider _healthSlider;

    private float _attackValue = 10;

    public void Attack()
    {
        if (_player.GetHealth() != 0)
        {
            _player.RemoveHealth(_attackValue);
            _healthSlider.ChangeSliderValue(_attackValue);
        }
    }
}
