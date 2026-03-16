using UnityEngine;
using UnityEngine.UI;

public class ApriFinestra : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _objectToSet;

    void Start()
    {
        _button.onClick.AddListener(Apri);
    }

    public void Apri()
    {
        _objectToSet.SetActive(!_objectToSet.activeSelf);
    }
}
