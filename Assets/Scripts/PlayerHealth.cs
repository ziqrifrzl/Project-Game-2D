using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public GameObject[] healthUI;

    void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            health = 0;
            GoalManager.singleton.PlayerLose();
        } 

        healthUI[health].SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.CompareTag("Enemy"))
        {
            TakeDamage();
        }
        else if (collison.CompareTag("GoldCoin"))
        {
            GoalManager.singleton.CoinColected();
            Destroy(collison.gameObject);
        }
        else if (collison.CompareTag("Key"))
        {
            GoalManager.singleton.GetKey();
            Destroy(collison.gameObject);
        }
        else if (collison.CompareTag("Goal"))
        {
            GoalManager.singleton.LevelCompleted();
        }

    }
}
