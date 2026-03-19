using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown3 : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] ListaPg listaPg;
    [SerializeField] GameObject img1;
    [SerializeField] GameObject img2;
    [SerializeField] GameObject img3;
    [SerializeField] GameObject img4;
    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();

        dropdown.onValueChanged.AddListener(AssociaImg);
        dropdown.ClearOptions();
        dropdown.AddOptions(listaPg.pg);

        img1.SetActive(false);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
    }

    public void AggiornaDropdown()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(listaPg.pg);
    }

    void AssociaImg(int scelta)
    {
        switch (scelta)
        {
            case 0:
                img1.SetActive(false);
                img2.SetActive(false);
                img3.SetActive(false);
                img4.SetActive(false);
                break;

            case 1:
                img1.SetActive(true);
                img2.SetActive(false);
                img3.SetActive(false);
                img4.SetActive(false);
                break;

            case 2:
                img1.SetActive(false);
                img2.SetActive(true);
                img3.SetActive(false);
                img4.SetActive(false);
                break;

            case 3:
                img1.SetActive(false);
                img2.SetActive(false);
                img3.SetActive(true);
                img4.SetActive(false);
                break;

            default:
                img1.SetActive(false);
                img2.SetActive(false);
                img3.SetActive(false);
                img4.SetActive(true);
                break;
        }
    }
}
