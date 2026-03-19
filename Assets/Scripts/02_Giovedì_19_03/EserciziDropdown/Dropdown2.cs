using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Dropdown2 : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] List<string> options = new List<string>(){"Seleziona...", "Facile", "Medio", "Difficile"};
    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();

        dropdown.onValueChanged.AddListener(SetDifficulty);
        dropdown.ClearOptions();
        dropdown.AddOptions(options);

        txt.text = "Seleziona Modalità...";
    }

    void SetDifficulty(int scelta)
    {
        if (scelta == 0)
        {
            txt.text = "Seleziona Modalità...";
        }
        if (scelta == 1)
        {
            txt.text = "Modalità Selezionata: Facile";
        }
        if (scelta == 2)
        {
            txt.text = "Modalità Selezionata: Medio";
        }
        if (scelta == 3)
        {
            txt.text = "Modalità Selezionata: Difficile";
        }
    }
}
