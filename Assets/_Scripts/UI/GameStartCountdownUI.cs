using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStartCountdownUI : MonoBehaviour
{
    private const string COUNTDOWN_NUMBER_POPUP = "NumberPopup";

    [SerializeField] private TextMeshProUGUI countdownText;
    private Animator animator;
    private int previousCountdownNumber;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GameManager.Instance.OnStateChanged += GameManager_OnStateChanged;
        GameManager.Instance.OnGamePaused += GameManager_OnGamePaused;

        Hide();
    }

    private void GameManager_OnGamePaused(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void GameManager_OnStateChanged(object sender, System.EventArgs e)
    {
        if (GameManager.Instance.IsCountdownToStartActive())
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Update()
    {
        int countdownNumber = Mathf.CeilToInt(GameManager.Instance.GetCountdowntoStartTimer());
        countdownText.text = countdownNumber.ToString();

        if (previousCountdownNumber != countdownNumber)
        {
            previousCountdownNumber = countdownNumber;
            animator.SetTrigger(COUNTDOWN_NUMBER_POPUP);
            SoundManager.Instance.PlayCountdownSound();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
