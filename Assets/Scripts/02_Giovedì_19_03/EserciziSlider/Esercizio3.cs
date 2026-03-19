using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Esercizio3 : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI textScala;
    [SerializeField] private GameObject objToChange;
    [SerializeField] private GameObject _objectToSet;
    [SerializeField] private Button buttonAttiva;
    [SerializeField] private Button buttonReset;

    void Start()
    {
        slider.GetComponent<Slider>();
        slider.minValue = 0;
        slider.maxValue = 5;
        slider.value = 5;

        textScala.GetComponent<TextMeshProUGUI>();

        objToChange.GetComponent<GameObject>();

        buttonAttiva.onClick.AddListener(SetSlider);
        buttonReset.onClick.AddListener(ResetScale);

        slider.onValueChanged.AddListener(UpdateScale);
        UpdateScale(slider.value);
    }

    private void UpdateScale(float value)
    {
        objToChange.transform.localScale = new Vector3(value, value, value);
        textScala.text = "Scala: " + objToChange.transform.localScale.ToString();
    }

    private void ResetScale()
    {
        //objToChange.transform.localScale = new Vector3(1, 1, 1);
        slider.value = 1;
    }

    private void SetSlider()
    {
        _objectToSet.SetActive(!_objectToSet.activeSelf);
    }
}
