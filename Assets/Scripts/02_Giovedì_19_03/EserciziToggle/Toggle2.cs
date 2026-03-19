using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Toggle2 : MonoBehaviour
{
    [SerializeField] private Toggle toggle1;
    [SerializeField] private Toggle toggle2;
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI text;


    void Start()
    {
        toggle1.isOn = false;
        toggle2.isOn = false;
        text.text = "Il panel è Attivo: " + toggle2.isOn.ToString() + " ->";

        toggle2.onValueChanged.AddListener(isAttivo);
        toggle1.onValueChanged.AddListener(isAttivo);
    }

    void isAttivo(bool attivo)
    {
        if (attivo)
        {
            text.text = "Il panel è Attivo: " + attivo.ToString() + " ->";
            panel.SetActive(true);
        }
        else
        {
            text.text = "Il panel è Attivo: " + attivo.ToString() + " ->";
            panel.SetActive(false);
        }
    }
}
