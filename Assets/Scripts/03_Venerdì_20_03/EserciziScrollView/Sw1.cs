using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sw1 : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;

    [SerializeField] TextMeshProUGUI itemPrefab;

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
        for (int i = 1; i <= 10; i++)
        {
            TextMeshProUGUI nuovoElemento = Instantiate(itemPrefab, scrollRect.content);
            nuovoElemento.text = $"Elemento {i}";
        }
    }
}
