using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textToSet;
    [SerializeField] private Button _buttonAumenta;
    [SerializeField] private Button _buttonDiminuisci;
    private int punti = 0;

    void Start()
    {
        _buttonAumenta.onClick.AddListener(AumentaPunti);
        _buttonDiminuisci.onClick.AddListener(DiminuisciPunti);
    }

    void Update()
    {
        AggiornaTesto();
    }

    void AumentaPunti()
    {
        punti += 5;
        AggiornaTesto();
    }

    void DiminuisciPunti()
    {
        punti -= 5;
        AggiornaTesto();
    }

    void AggiornaTesto()
    {
        _textToSet.text = "Punti: " + punti;
    }
}
