using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject DeathUI;
    public TextMeshProUGUI scoreText;
    [Header("Score")]

    public int score = 0;

    [Header("Timer")]
    public float timer = 0f;
    public float gameEndTime = 120f;
    private bool isSlowMo = false;

    void Awake()
    {
        ResetGame();
        DeathUI.SetActive(false);

    }

    void Update()
    {
        timer += Time.unscaledDeltaTime;

        if (!isSlowMo && timer >= gameEndTime)
        {
            DeathUI.SetActive(true);
            isSlowMo = true;
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime = 0.2f * 0.02f; 
        }
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = " " + score;

    }

        public void ResetGame()
    {
        scoreText.text = " " + score;
        score = 0;
        timer = 0f;
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
    }
}