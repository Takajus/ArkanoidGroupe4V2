using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInfoManager : MonoBehaviour
{
    public PlayerScoreController playerInfo;
    public TextMeshProUGUI scoreText;
    [SerializeField] private GameObject[] health;
    public GameObject playerhealthIcon;
    public GameObject gameoverScreen;

    // Start is called before the first frame update
    void Start()
    {
        playerInfo.life = 3;
        playerInfo.score = 0;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + playerInfo.score;

        HealthUpdate();
    }

    private void HealthUpdate()
    {
        for (int i = 0; i < playerInfo.life; i++)
        {
            health[i].SetActive(true);
        }

        if ( playerInfo.life == 2)
        {
            health[2].SetActive(false);
        }else if ( playerInfo.life == 1)
        {
            health[2].SetActive(false);
            health[1].SetActive(false);
        }
        else if ( playerInfo.life == 0)
        {
            health[2].SetActive(false);
            health[1].SetActive(false);
            health[0].SetActive(false);
            GameOver();
            //Game over <----------------------------------
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        gameoverScreen.SetActive(true);
        GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>().text = "Score : " + playerInfo.score;
    }
}
