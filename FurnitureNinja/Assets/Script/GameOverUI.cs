using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public DataManager dataManager;
    [SerializeField] Button replayBtn;
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject gameManager;
    [SerializeField] GameObject gamePlayPanel;
    [SerializeField] GameObject[] star;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text gamePlayScoreTxt;
    GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        replayBtn.onClick.AddListener(TaskOnTouchReplay);
    }

    // replay butonuna basildigindaki isleri gercekler
    void TaskOnTouchReplay()
    {
        // yildizlari aktif eder
        for (int i = 0; i < star.Length; ++i)
        {
            star[i].SetActive(true);
        }
        
        spawnPoint = Instantiate(spawner); // spawn pointi resetlemek icin tekrardan olsuturur
        spawnPoint.name = "Spawner"; // adindan bulabilmek icin rename yapar
        gameManager.SetActive(true); // blade i aktif eder
        gamePlayPanel.SetActive(true);
        gamePlayScoreTxt.text = "0";
        gameObject.SetActive(false);
    }

    // oyun sonundaki scoreyi yazdirmak icin kullanilir
    public void SetScore(int score)
    {
        scoreTxt.text = "Score: " + score;
        HighScoreEditor(score);
    }

    // data manger icinde yuksek skoru saklar
    void HighScoreEditor(int score)
    {
        dataManager.Load();
        if (score > dataManager.data.GetHighScore())
        {
            dataManager.data.SetHighScore(score);
        }        
        dataManager.Save();
    }
}
