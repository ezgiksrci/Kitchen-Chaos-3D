using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsUI : MonoBehaviour
{
    public static OptionsUI Instance { get; private set; }

    [SerializeField] private Slider soundEffectsSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button quitButton;

    [Header("Key Binding Buttons")]
    [SerializeField] private Button moveUpButton;
    [SerializeField] private Button moveDownButton;
    [SerializeField] private Button moveLeftButton;
    [SerializeField] private Button moveRightButton;
    [SerializeField] private Button interactButton;
    [SerializeField] private Button interactAlternateButton;
    [SerializeField] private Button pauseButton;

    [Header("Key Binding Texts")]
    [SerializeField] private TextMeshProUGUI moveUpText;
    [SerializeField] private TextMeshProUGUI moveDownText;
    [SerializeField] private TextMeshProUGUI moveLeftText;
    [SerializeField] private TextMeshProUGUI moveRightText;
    [SerializeField] private TextMeshProUGUI interactText;
    [SerializeField] private TextMeshProUGUI interactAlternateText;
    [SerializeField] private TextMeshProUGUI pauseText;

    private void Awake()
    {
        Instance = this;

        soundEffectsSlider.onValueChanged.AddListener(value =>
        {
            SoundManager.Instance.ChangeVolume(value);
        });

        musicSlider.onValueChanged.AddListener(value =>
        {
            MusicManager.Instance.ChangeMusicVolume(value);
        });

        resumeButton.onClick.AddListener(() =>
        {
            GameManager.Instance.TogglePauseGame();
            Hide();
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });

        //moveUpButton.onClick.AddListener

    }


    private void Start()
    {
        GameManager.Instance.OnGameUnpaused += GameManager_OnGameUnpaused;
        Hide();

        soundEffectsSlider.value = SoundManager.Instance.GetVolume();
        musicSlider.value = MusicManager.Instance.GetVolume();

        UpdateVisual();
    }
    private void GameManager_OnGameUnpaused(object sender, EventArgs e)
    {
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void UpdateVisual()
    {
        moveUpText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Up);
        moveDownText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Down);
        moveLeftText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Left);
        moveRightText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Right);
        interactText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Interact);
        interactAlternateText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Interact_Alternate);
        pauseText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Pause);
    }
}
