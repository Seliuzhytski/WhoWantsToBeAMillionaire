using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishWhoWantsToBeAMillionaire : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;

    private void Start()
    {
        _score.text = $"Ваш результат: \n {GameWhoWantsToBeAMillionaire.Counter}";
    }
}
