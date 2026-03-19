using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input1 : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] TextMeshProUGUI nome;

    void Start()
    {
        input.onSubmit.AddListener(VerificaNumero);

        nome.text = "Numero maggiore di 100? ";
    }

    void VerificaNumero(string testo)
    {
        nome.text = "Numero maggiore di 100? ";

        if (!string.IsNullOrEmpty(testo))
        {
            decimal n;

            if (decimal.TryParse(testo, out n))
            {
                if (n > 100) {nome.text += "Vero!";}
                else {nome.text += "Falso!";}
            }
        }
    }
}
