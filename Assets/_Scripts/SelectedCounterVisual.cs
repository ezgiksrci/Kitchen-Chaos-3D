using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] selectedCounterVisuals;

    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnOnSelectedCounterChanged;
    }

    private void Player_OnOnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        foreach (GameObject selectedCounterVisual in selectedCounterVisuals)
        {
            selectedCounterVisual.SetActive(true);
        }
    }

    private void Hide()
    {
        foreach (GameObject selectedCounterVisual in selectedCounterVisuals)
        {
            selectedCounterVisual.SetActive(false);
        }
    }
}