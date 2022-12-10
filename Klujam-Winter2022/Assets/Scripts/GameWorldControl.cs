using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorldControl : MonoBehaviour
{
    
    [SerializeField] GameObject Tile;

    public int ColumnLength;
    public int RowHeight;
    TileBehavior tileBehavior;
    bool once = false;

    public static GameWorldControl instance;

    public GameObject[,] GameWorld;

    private float ySpacer = 0;
    private float xSpacer = 0;

    public bool player1Playing;

    void Awake()
    {
        
        instance = this;

        
        tileBehavior = Tile.GetComponent<TileBehavior>();
        GameWorld = new GameObject[ColumnLength, RowHeight];
        for (int i = 0; i < ColumnLength; i++)
        {
            ySpacer = 0;
            xSpacer = xSpacer + 0.2f;
            for (int j = 0; j < RowHeight; j++)
            {

                GameWorld[i, j] = (GameObject)Instantiate(Tile, new Vector3(i - 2.78f, j - 2.78f, 0), Quaternion.identity);
                GameWorld[i,j].GetComponent<TileBehavior>().hiddenAttribute = Random.Range(-4, 5);
                GameWorld[i, j].transform.Translate(new Vector3(xSpacer, ySpacer, 0));
                ySpacer = ySpacer + 0.2f;

            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
       player1Playing=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer.instance.roundDone == true)
        {
            StartCoroutine(waitTimer());
            
        }
    }

    void calculateScores()
    {
        int roundScoreplayer1 = 0;
        int roundScoreplayer2 = 0;
        for (int i = 0; i < ColumnLength; i++)
        {
            for (int j = 0; j < RowHeight; j++)
            {
                roundScoreplayer1 = roundScoreplayer1 + (GameWorld[i, j].GetComponent<TileBehavior>().numOfPlayer1fishes * GameWorld[i, j].GetComponent<TileBehavior>().hiddenAttribute);
                roundScoreplayer2 = roundScoreplayer2 + (GameWorld[i, j].GetComponent<TileBehavior>().numOfPlayer2fishes * GameWorld[i, j].GetComponent<TileBehavior>().hiddenAttribute);
            }
        }
        pointsManager.instance.addPoints(roundScoreplayer1);
        pointsManager.instance.addPointsPlayer2(roundScoreplayer2);

    }

    public void player2Go()
    {
        player1Playing = false;
        Timer.instance.resetTimer();
    }

    void resetGameWorld()
    {
        for (int i = 0; i < ColumnLength; i++)
        {
            for (int j = 0; j < RowHeight; j++)
            {
                GameWorld[i, j].GetComponent<TileBehavior>().hiddenAttribute = Random.Range(-4, 5);
                GameWorld[i, j].GetComponent<TileBehavior>().numOfPlayer1fishes = 0;
                GameWorld[i, j].GetComponent<TileBehavior>().numOfPlayer2fishes = 0;
            }
        }
    }

    public void player1Go()
    {
        player1Playing = true;
        Timer.instance.resetTimer();
    }

    public IEnumerator waitTimer()
    {
        calculateScores();
        Timer.instance.roundDone = false;

        for (int i = 0; i < ColumnLength; i++)
        {
            for (int j = 0; j < RowHeight; j++)
            {
                GameWorld[i, j].GetComponent<TileBehavior>().showValues();
            }
        }

        yield return new WaitForSeconds(3);

        for (int i = 0; i < ColumnLength; i++)
        {
            for (int j = 0; j < RowHeight; j++)
            {
                GameWorld[i, j].GetComponent<TileBehavior>().hideValues();
            }
        }
        resetGameWorld();
        

    }
}
