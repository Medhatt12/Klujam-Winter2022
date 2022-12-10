using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorldControl : MonoBehaviour
{
    
    [SerializeField] GameObject Tile;

    public int ColumnLength;
    public int RowHeight;
    TileBehavior tileBehavior;



    public GameObject[,] GameWorld;

    private float ySpacer = 0;
    private float xSpacer = 0;

    void Awake()
    {
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}
