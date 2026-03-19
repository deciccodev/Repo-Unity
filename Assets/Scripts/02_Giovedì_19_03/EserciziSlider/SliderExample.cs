using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SliderExample : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider.GetComponent<Slider>();

        slider.minValue = 0;
        slider.maxValue = 100;
        slider.wholeNumbers = true;
        slider.onValueChanged.AddListener(onSliderChanged);
    }

    private void onSliderChanged(float amount)
    {
        Debug.Log($"Il valore dello slider è {amount}");
    }
}
