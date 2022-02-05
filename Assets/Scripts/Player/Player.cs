using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health = 50;

    //[SerializeField] private PlayerHealthSlider _healthSlider;

    public float GetHealth()
    {
        return _health;
    }

    public void AddHealth(float healValue)
    {
        _health += healValue;
        //_healthSlider.ChangeSliderValue(healValue);
    }

    public void RemoveHealth(float healValue)
    {
        _health -= healValue;
        //_healthSlider.ChangeSliderValue(healValue);
    }
}
