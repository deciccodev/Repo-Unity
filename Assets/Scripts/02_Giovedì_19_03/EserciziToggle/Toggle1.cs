using UnityEngine;
using UnityEngine.UI;

public class Toggle1 : MonoBehaviour
{
    [SerializeField] private Toggle toggle1;
    [SerializeField] private GameObject panel;

    void Start()
    {
        toggle1.isOn = false;
        toggle1.onValueChanged.AddListener(isAttivo);
    }

    void isAttivo(bool attivo)
    {
        if (attivo)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
