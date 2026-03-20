using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sw2 : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;

    [SerializeField] Button itemPrefab;

    void Start()
    {
        if (scrollRect == null)
        {
            scrollRect = GetComponent<ScrollRect>();
        }

        AggiungiElementi();
    }

    private void AggiungiElementi()
    {
        for (int i = 1; i <= 20; i++)
        {
            int indexBottone = i;

            Button nuovoElemento = Instantiate(itemPrefab, scrollRect.content);
            nuovoElemento.GetComponentInChildren<TextMeshProUGUI>().text = $"Bottone {indexBottone}"; 
            nuovoElemento.onClick.AddListener(() => Debug.Log("Bottone Numero: " + indexBottone));
        }
    }
}
