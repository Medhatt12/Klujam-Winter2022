using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorldControl : MonoBehaviour
{
    [SerializeField] GameObject Tile;

    public int ColumnLength;
    public int RowHeight;

    [SerializeField] public GameObject Grid;

    public GameObject[,] GameWorld;

    private float ySpacer = 0;
    private float xSpacer = 0;


    // Start is called before the first frame update
    void Start()
    {
        GameWorld = new GameObject[ColumnLength, RowHeight];
        for (int i = 0; i < ColumnLength; i++)
        {
            ySpacer = 0;
            xSpacer = xSpacer + 0.2f;
            for (int j = 0; j < RowHeight; j++)
            {
                
                GameWorld[i,j] = (GameObject)Instantiate(Tile, new Vector3(i - 2.78f, j - 2.78f, 0), Quaternion.identity);
                GameWorld[i, j].transform.SetParent(Grid.transform, false);
                GameWorld[i,j].transform.Translate(new Vector3(xSpacer, ySpacer, 0));
                ySpacer = ySpacer + 0.2f;

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
