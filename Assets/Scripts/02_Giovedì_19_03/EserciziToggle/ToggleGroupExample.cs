using UnityEngine;
using UnityEngine.UI;

public class ToggleGroup : MonoBehaviour
{
    [SerializeField] private Toggle toggleGroup;

    void Start()
    {
        toggleGroup.onValueChanged.AddListener(StampaAttivo);
    }

    void StampaAttivo(bool attivo)
    {
        Debug.Log($"Toggle Attivo: {attivo}");
    }
}
