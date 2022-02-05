using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerHealthSlider _healthSlider;

    private float _healValue = 10;

    public void Heal()
    {
        if (_player.GetHealth() != 100)
        {
            _player.AddHealth(_healValue);
            _healthSlider.ChangeSliderValue(_healValue);
        }
    }
}
