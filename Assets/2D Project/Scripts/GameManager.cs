using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject GameOverText;
    
    private int currentScore = 0;
    private int highScore = 0;
    
    public EnemyGroupMovement enemyGroup;
    private int enemiesRemaining = 40;
    

    void Start()
    {
        Enemy.OnEnemyDied += OnEnemyDied;
        GameOverText.SetActive(false);
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        UpdateUI();
    }

    void OnDestroy()
    {
        Enemy.OnEnemyDied -= OnEnemyDied;
    }

    void OnEnemyDied(float score)
    {
        currentScore += (int)score;

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        enemiesRemaining--;

        enemyGroup.moveInterval *= 0.95f;

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = currentScore.ToString("D4");
        highScoreText.text = highScore.ToString("D4");
    }
}

/* using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Enemy.OnEnemyDied += OnEnemyDied;
        // todo - sign up for notification about enemy death 
    }

    void OnDestroy()
    {
        Enemy.OnEnemyDied -= OnEnemyDied;
    }

    void OnEnemyDied(float score)
    {
        Debug.Log($"Killed enemy worth {score}");
    }
} */
