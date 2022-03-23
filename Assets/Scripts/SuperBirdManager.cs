using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SuperBirdManager : MonoBehaviour
{
    public Bird bird;
    public TMP_Text textScore;
    public TMP_Text textSumScore;
    public TMP_Text textHighScore;

    public GameObject summaryPanel;
    bool birdPreviousState = false;
    int high_score = 0;

    public UnityEvent onGameFinished;
    public UnityEvent onNewHighScore;

    // Start is called before the first frame update
    void Start()
    {
        birdPreviousState = bird.isDead;
        summaryPanel.SetActive(false);
        high_score = LoadScoreFromDisk();
        textHighScore.text = high_score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = bird.score.ToString();

        if (birdPreviousState != bird.isDead) {
            OnBirdDead();
            birdPreviousState = bird.isDead;
            onGameFinished.Invoke();
        }
    }

    void OnBirdDead() {
        summaryPanel.SetActive(bird.isDead);
        textSumScore.text = bird.score.ToString();

        if (bird.score > high_score) { // New highscore
            onNewHighScore.Invoke();
            SaveScoreToDisk(bird.score);
            textHighScore.text = bird.score.ToString();
        }
    }

    public void TryAgain() {
        SceneManager.LoadScene("SuperBird");
    }

    public void Home() {
        SceneManager.LoadScene("Home");
    }

    public void SaveScoreToDisk(int score) {
        PlayerPrefs.SetInt("HIGH_SCORE", score);
    }

    public int LoadScoreFromDisk() {
        if (!PlayerPrefs.HasKey("HIGH_SCORE")) {
            return 0;
        }
        return PlayerPrefs.GetInt("HIGH_SCORE");
    }

    public void ResetHighScoreOnDisk() {
        PlayerPrefs.SetInt("HIGH_SCORE", 0);
        textHighScore.text = "0";
    }
}
