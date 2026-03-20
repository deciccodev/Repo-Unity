using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input3 : MonoBehaviour
{
    [SerializeField] TMP_InputField inputNome;
    [SerializeField] TMP_InputField inputEmail;
    [SerializeField] TMP_InputField inputMessaggio;
    [SerializeField] Button btnInvia;
    [SerializeField] TextMeshProUGUI check;

    void Start()
    {
        if (inputNome == null){inputNome = GetComponent<TMP_InputField>();}
        if (inputEmail == null){inputEmail = GetComponent<TMP_InputField>();}
        if (inputMessaggio == null){inputMessaggio = GetComponent<TMP_InputField>();}

        check.text = "Checking...";

        btnInvia.onClick.AddListener(ControllaCampo);
    }

    public void ControllaCampo()
    {
        check.text = "";

        bool vuoto = false;

        if (inputNome.text == "")
        {
            inputNome.GetComponent<Image>().color = new Color32(253, 127, 127, 255);
            vuoto = true;
            check.text += "Campo mancante: Nome - ";
        }
        if (inputEmail.text == "")
        {
            inputEmail.GetComponent<Image>().color = new Color32(253, 127, 127, 255);
            vuoto = true;
            check.text += "Campo mancante: Email - ";
        }
        if (inputMessaggio.text == "")
        {
            inputMessaggio.GetComponent<Image>().color = new Color32(253, 127, 127, 255);
            vuoto = true;
            check.text += "Campo mancante: Messaggio";
        }
        if (!vuoto) 
        {
            check.text = "Tutto Giusto!";
            ResetCampi();
        }
    }

    void ResetCampi()
    {
        inputNome.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        inputEmail.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        inputMessaggio.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        
        inputNome.text = "";
        inputEmail.text = "";
        inputMessaggio.text = "";
    }
}
