using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ListaPg : MonoBehaviour
{
    [SerializeField] TMP_InputField input;
    [SerializeField] Dropdown3 d3;

    public List<string> pg = new List<string>(){"Seleziona pg", "Pippo", "Pluto", "Paperino"};

    void Start()
    {
        input.onEndEdit.AddListener(AggiungiAllaLista);

        input.text = "Inserisci PG da aggiungere...";
    }

    void AggiungiAllaLista(string testo)
    {
        if (!string.IsNullOrEmpty(testo))
        {
            pg.Add(testo);
            d3.AggiornaDropdown();

            input.text = "Inserisci PG da aggiungere...";
        }
    }
}
