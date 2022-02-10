using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class PlayerHealthSlider : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;

    private const float changeSpeed = 25;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = 0;
        _slider.maxValue = 100;
        _slider.value = _player.Health;
    }

    private void Update()
    {
        if(_slider.value != _player.Health)
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Health, changeSpeed * Time.deltaTime);
    }
}