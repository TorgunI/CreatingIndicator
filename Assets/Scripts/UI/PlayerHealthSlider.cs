using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSlider : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = 0;
        _slider.maxValue = 100;
        _slider.value = _player.GetHealth();
    }

    public void ChangeSliderValue(float deltaValue)
    {
        StartCoroutine(ChangeValue(deltaValue));
    }

    private IEnumerator ChangeValue(float deltaValue)
    {
        while (_slider.value != _player.GetHealth())
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.GetHealth(), deltaValue * Time.deltaTime);
            yield return null;
        }
    }
}