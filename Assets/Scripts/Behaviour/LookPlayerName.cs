using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LookPlayerName : MonoBehaviour
{
    private TMP_Text _nameText;

    private void Awake()
    {
        _nameText = GetComponentInChildren<TMP_Text>();
        _nameText.text = GameManager.Instance._playerData._name;
    }
}