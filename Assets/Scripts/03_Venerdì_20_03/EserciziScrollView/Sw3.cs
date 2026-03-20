using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sw3 : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;

    [SerializeField] Button btnInvia;
    [SerializeField] TMP_InputField inputNome;
    [SerializeField] TMP_InputField inputMessaggio;
    [SerializeField] TextMeshProUGUI prefabTxt;

    void Start()
    {
        if (scrollRect == null)
        {
            scrollRect = GetComponent<ScrollRect>();
        }

        btnInvia.onClick.AddListener(AggiungiElementi);
    }

    void AggiungiElementi()
    {
        if(inputNome.text != "" || inputMessaggio.text != "")
        {
            TextMeshProUGUI nuovoElemento = Instantiate(prefabTxt, scrollRect.content);
            nuovoElemento.color = Color.black;
            nuovoElemento.text = inputNome.text + ": " + inputMessaggio.text;
        }

        ResetInput();

        Canvas.ForceUpdateCanvases();

        scrollRect.verticalNormalizedPosition = 0f;
    }

    void ResetInput()
    {
        inputNome.text = "";
        inputMessaggio.text = "";
    }
}
