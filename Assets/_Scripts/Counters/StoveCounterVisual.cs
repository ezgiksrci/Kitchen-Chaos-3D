using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveCounterVisual : MonoBehaviour
{
    [SerializeField] StoveCounter stoveCounter;
    [SerializeField] GameObject sizzlingParticles;
    [SerializeField] GameObject stoveOnVisual;

    private void Start()
    {
        GameManager.Instance.OnGameOver += GameManager_OnGameOver;
        stoveCounter.OnStateChanged += StoveCounter_OnStateChanged;
    }

    private void GameManager_OnGameOver(object sender, EventArgs e)
    {
        sizzlingParticles.SetActive(false);
        stoveOnVisual.SetActive(false);
    }

    private void StoveCounter_OnStateChanged(object sender, StoveCounter.OnStateChangedEventArgs e)
    {
        bool showVisual = e.state == StoveCounter.State.Frying || e.state == StoveCounter.State.Fried;

        sizzlingParticles.SetActive(showVisual);
        stoveOnVisual.SetActive(showVisual);
    }
}
