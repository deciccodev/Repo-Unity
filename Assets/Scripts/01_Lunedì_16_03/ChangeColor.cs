using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private float speed = 1f;

    private float colore;

    void Update()
    {
        colore += Time.deltaTime * speed;
        if (colore > 1f) colore = 0f;

        Color rgbColor = Color.HSVToRGB(colore, 1f, 1f);
        buttonText.color = rgbColor;
    }

    public void CambiaColore()
    {
        _image.color = Random.ColorHSV(0f, 1f);
    }

    public void ChiamaCambiaColore()
    {
        CambiaColore();
    }
}
