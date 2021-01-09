using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Brick;
    public float BrickWidth;
    public float BrickHeight;
    public int ScreenSize;
    public Transform startBrick;
    [SerializeField]
    private int BrickMaxWidth;
    public int BrickMaxHeight;

    void Start()
    {
        BrickMaxWidth = ScreenSize / (int)BrickWidth;
        for (int i = 0; i < BrickMaxWidth-1; i++)
        {
            for(int j=0;j<BrickMaxHeight;j++)
            {
                Instantiate(Brick, new Vector3(startBrick.position.x + i * BrickWidth / 100, startBrick.position.y - j*BrickHeight/100, startBrick.position.z), transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      


    }
}
