using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour
{
    GameObject player;
    GameObject hpGauge;
    public Text score;
    int gameScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.player = GameObject.Find("player");
    }
void Update()
    {
        score.text = "Score : " + gameScore;
    }
    public void IncreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.2f;

    }
    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.025f;
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
    public void GetCoin()
    {
        this.gameScore += 10;
    }

}