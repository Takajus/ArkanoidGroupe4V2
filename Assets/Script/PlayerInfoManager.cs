using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInfoManager : MonoBehaviour
{
    public PlayerScoreController playerInfo;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerInfo.life = 3;
        playerInfo.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + playerInfo.score;
    }
}
