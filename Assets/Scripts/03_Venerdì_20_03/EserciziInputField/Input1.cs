using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input1Pg : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] TextMeshProUGUI nome;

    void Start()
    {
        input.onEndEdit.AddListener(StampaNome);

        nome.text = "Il tuo nome è: ";
    }

    void StampaNome(string testo)
    {
        if (!string.IsNullOrEmpty(testo))
        {
            nome.text += testo;
        }
    }
}
