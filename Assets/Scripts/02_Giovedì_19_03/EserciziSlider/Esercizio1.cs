using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Esercizio1 : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI textToChange;

    void Start()
    {
        slider.GetComponent<Slider>();
        slider.minValue = 1;
        slider.maxValue = 10;

        textToChange.GetComponent<TextMeshProUGUI>();
        slider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        textToChange.text = "Value: " + value.ToString();
    }
}
