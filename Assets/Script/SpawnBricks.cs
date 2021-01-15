using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBricks : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Brick;
    public float BrickWidth;
    public float BrickHeight;
    public int ScreenSize;
    public Transform startBrick;
    public Transform startBrickMiddle;
    public List<Sprite> ListeSprite;
    [SerializeField]
    private int BrickMaxWidth;
    public int BrickMaxHeight;
    public LevelType levelType;

    void Start()
    {
        
        BrickMaxWidth = ScreenSize / (int)BrickWidth;
        if(levelType==LevelType.Block)
        {
            CreateLevelBlock();
        }else if(levelType==LevelType.HoleMiddle)
        {
            CreateHoleMiddle();
        }else if(levelType==LevelType.Pyramidal)
        {
            CreatePyramidal();
        }
       
    }

    void CreateLevelBlock()
    {
        for (int i = 0; i < BrickMaxWidth - 1; i++)
        {
            for (int j = 0; j < BrickMaxHeight; j++)
            {
                GameObject brick = Instantiate(Brick, new Vector3(startBrick.position.x + i * BrickWidth / 100, startBrick.position.y - j * BrickHeight / 100, startBrick.position.z), transform.rotation);
                brick.GetComponent<SpriteRenderer>().sprite = ListeSprite[Random.Range(0, ListeSprite.Count)];
            }
        }
    }

    void CreateHoleMiddle()
    {
        for (int i = 0; i < BrickMaxWidth - 1; i++)
        {
            for (int j = 0; j < BrickMaxHeight+2; j++)
            {
                if(j<=2 || i <= 1 || i >= BrickMaxWidth - 3)
                {
                GameObject brick = Instantiate(Brick, new Vector3(startBrick.position.x + i * BrickWidth / 100, startBrick.position.y - j * BrickHeight / 100, startBrick.position.z), transform.rotation);
                brick.GetComponent<SpriteRenderer>().sprite = ListeSprite[Random.Range(0, ListeSprite.Count)];
                }
            }
        }
    }

    void CreatePyramidal()
    {
        for(int j=0;j<BrickMaxHeight+1;j++)
        {
            GameObject brick3 = Instantiate(Brick, new Vector3(startBrickMiddle.position.x, startBrickMiddle.position.y - j * BrickHeight / 100, startBrickMiddle.position.z), transform.rotation);
            brick3.GetComponent<SpriteRenderer>().sprite = ListeSprite[Random.Range(0, ListeSprite.Count)];
            for (int i=1;i<BrickMaxWidth/2-j;i++)
        {
            GameObject brick = Instantiate(Brick, new Vector3(startBrickMiddle.position.x + i * BrickWidth / 100, startBrickMiddle.position.y - j * BrickHeight/100, startBrickMiddle.position.z), transform.rotation);
            brick.GetComponent<SpriteRenderer>().sprite = ListeSprite[Random.Range(0, ListeSprite.Count)];
            GameObject brick2 = Instantiate(Brick, new Vector3(startBrickMiddle.position.x - i * BrickWidth / 100, startBrickMiddle.position.y - j * BrickHeight/100, startBrickMiddle.position.z), transform.rotation);
            brick2.GetComponent<SpriteRenderer>().sprite = ListeSprite[Random.Range(0, ListeSprite.Count)];
            
            }
        }
    }


    public enum LevelType
    {
        Block,
        Pyramidal,
        HoleMiddle,
    }
}
