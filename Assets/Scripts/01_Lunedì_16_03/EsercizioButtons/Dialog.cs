using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField] private Button _buttonConferma;
    [SerializeField] private Button _buttonAnnulla;
    [SerializeField] private GameObject _objectToSet;

    void Start()
    {
        _buttonConferma.onClick.AddListener(Conferma);
        _buttonAnnulla.onClick.AddListener(Annulla);
    }

    void Update()
    {
        /*Conferma();
        Annulla();*/
    }

    public void Annulla()
    {
        _objectToSet.SetActive(false);
    }

    public void Conferma()
    {
        Debug.Log("Chiusura finestra!");
        _objectToSet.SetActive(false);
    }
}
