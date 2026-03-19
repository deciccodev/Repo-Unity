using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Toggle3 : MonoBehaviour
{
    [SerializeField] private Toggle toggle1;
    [SerializeField] private Toggle toggle2;
    [SerializeField] private Toggle toggle3;
    [SerializeField] private GameObject img;
    [SerializeField] private GameObject txt;
    [SerializeField] private GameObject btn;
    [SerializeField] private TextMeshProUGUI checkTxt;


    void Start()
    {
        toggle1.isOn = false;
        toggle2.isOn = false;
        toggle3.isOn = false;

        img.SetActive(false);
        txt.SetActive(false);
        btn.SetActive(false);

        checkTxt.text += "Elementi attivi: Nessun elemento attivo";

        toggle1.onValueChanged.AddListener(isAttivo);
        toggle2.onValueChanged.AddListener(isAttivo);
        toggle3.onValueChanged.AddListener(isAttivo);
    }

    void isAttivo(bool attivo)
    {
        img.SetActive(toggle1.isOn);
        txt.SetActive(toggle2.isOn);
        btn.SetActive(toggle3.isOn);

        checkTxt.text = "Elementi attivi: ";

        bool nessuno = true;

        if (toggle1.isOn)
        {
            checkTxt.text += "Immagine, ";
            nessuno = false;
        } 
        if (toggle2.isOn)
        {
            checkTxt.text += "Testo, ";
            nessuno = false;
        } 
        if (toggle3.isOn)
        {
            checkTxt.text += "Bottone, ";
            nessuno = false;
        }
        if (nessuno)
        {
            checkTxt.text += "Nessun elemento attivo";
        }
    }
}
