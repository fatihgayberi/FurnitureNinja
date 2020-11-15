using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour
{
    GameOverUI gameOverUI;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject[] star; // oyundaki can sayilarini tutar Inseptor panelinden yeni yildiz eklenerek can sayisi arttirilabilir
    [SerializeField] Text scorerTxt;
    [SerializeField] GameObject gameManager;
    int score = 0;
    int health;

    void Start()
    {
        health = star.Length; // yildiz sayisina gore cani tutar
    }

    // obje parcalandiginda cagirilir ve scoreBoardı update eder
    public void ScoreWinner()
    {
        score++;
        scorerTxt.text = score + "";
    }

    // obje kacirildiginda cagirilir
    public void HealthLose()
    {
        health--;
        star[health].SetActive(false);

        // tum canlar bittiginde Game Over olmasini saglar
        if (health <= 3)
        {
            Destroy(GameObject.Find("Spawner"));
            gameManager.SetActive(false);
            gameOverPanel.SetActive(true);
            gameOverUI = FindObjectOfType<GameOverUI>();
            gameOverUI.SetScore(score);
            score = 0;
            health = star.Length;
            gameObject.SetActive(false);
        }
    }
}
