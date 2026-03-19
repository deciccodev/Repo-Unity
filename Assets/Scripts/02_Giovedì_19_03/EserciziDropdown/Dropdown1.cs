using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown1: MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] GameObject panel;
    [SerializeField] List<string> options = new List<string>(){"Rosso", "Verde", "Blu"};
    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        
        panel.GetComponent<Image>().color = Color.red;

        dropdown.onValueChanged.AddListener(CambiaColore);
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
    }

    void CambiaColore(int scelta)
    {
        if (scelta == 0)
        {
            panel.GetComponent<Image>().color = Color.red;
        }
        if (scelta == 1)
        {
            panel.GetComponent<Image>().color = Color.green;
        }
        if (scelta == 2)
        {
            panel.GetComponent<Image>().color = Color.blue;
        }
    }
}