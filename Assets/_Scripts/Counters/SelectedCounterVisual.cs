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
        // If the selected counter is the same as the counter, show the visuals.
        if (e.selectedCounter == baseCounter)
        {
            Show();
        }
        // If the selected counter is not the same as the counter, hide the visuals.
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        // Show the selected counter visuals.
        foreach (GameObject selectedCounterVisual in selectedCounterVisuals)
        {
            selectedCounterVisual.SetActive(true);
        }
    }

    private void Hide()
    {
        // Hide the selected counter visuals.
        foreach (GameObject selectedCounterVisual in selectedCounterVisuals)
        {
            selectedCounterVisual.SetActive(false);
        }
    }
}