using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{
    public DataManager dataManager;
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject gameManager;
    [SerializeField] GameObject gamePlayPanel;
    [SerializeField] Button playBtn;
    [SerializeField] Text highScoreTxt;


    // Start is called before the first frame update
    void Start()
    {
        playBtn.onClick.AddListener(TaskOnTouchPlay);
        HighScore();
    }

    // play butonuna basilmasini dinler
    void TaskOnTouchPlay()
    {
        spawner.SetActive(true);
        gameManager.SetActive(true);
        gamePlayPanel.SetActive(true);
        gameObject.SetActive(false);
    }

    // highScore yi output eder
    void HighScore()
    {
        dataManager.Load();
        highScoreTxt.text = "High Score: " + dataManager.data.GetHighScore();
    }
}
