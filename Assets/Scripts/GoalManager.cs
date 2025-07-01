using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public static GoalManager singleton;
    public int score;
    public Text[] scoreUI = new Text[3];
    public GameObject Lock;
    public GameObject unLock;

    // Mereferensikan Player Lose dan Win
    public GameObject playerLose;
    public GameObject playerWin;

    private void Awake()
    {
        singleton = this;
    }

    public void CoinColected()
    {
        score++;
        scoreUI[0].text = score.ToString();
    }

    public void GetKey()
    {
        Lock.SetActive(false);
        unLock.SetActive(true);
    }

    public void PlayerLose()
    {
        Time.timeScale = 0;
        playerLose.SetActive(true);
        scoreUI[1].text = score.ToString();
    }
    public void LevelCompleted()
    {
        Time.timeScale = 0;
        playerWin.SetActive(true);
        scoreUI[2].text = score.ToString();
    }

}
