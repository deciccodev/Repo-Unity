using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExamples : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private List<GameObject> _buttons;

    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() =>
        {
            foreach (var o in _buttons)
            {
                o.SetActive(!o.activeSelf);
            }
        });
    }
}
