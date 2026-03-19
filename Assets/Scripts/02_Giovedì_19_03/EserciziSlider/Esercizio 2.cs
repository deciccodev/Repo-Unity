using UnityEngine;
using UnityEngine.UI;

public class Esercizio2 : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Light lightToSet;

    void Start()
    {
        slider.GetComponent<Slider>();
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = 100;

        lightToSet.GetComponent<Light>();

        slider.onValueChanged.AddListener(SetLight);
    }

    

    public void SetLight(float value)
    {
        lightToSet.intensity = value;
    }
}
