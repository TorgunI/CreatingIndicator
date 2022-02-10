using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;

    private const float deltaValue = 25;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = _player.MinHealth;
        _slider.maxValue = _player.MaxHealth;
        _slider.value = _player.Health;
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        StartCoroutine(ChangeSliderValue());
    }

    private IEnumerator ChangeSliderValue()
    {
        while (_slider.value != _player.Health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, deltaValue * Time.deltaTime);
            yield return null;
        }
    }
}