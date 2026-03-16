using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stampa : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textToSet;
    [SerializeField] private Button _buttonStampa;

    void Start()
    {
        _buttonStampa.onClick.AddListener(StampaMessaggio);
    }

    public void StampaMessaggio()
    {
        Debug.Log("Bottone stampa cliccato");
        _textToSet.text = "Ciao, hai cliccato il bottone!";
    }
}
