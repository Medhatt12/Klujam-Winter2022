using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    GameWorldControl gameWorldControl;
    [SerializeField] GameObject gameController;

    void Awake()
    {
        gameWorldControl = GameObject.Find("GameController").GetComponent<GameWorldControl>();
    }
    // Start is called before the first frame update
    void Start()
    {
       // gameWorldControl.GameWorld[0, 0].GetComponent<TileBehavior>().isSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
        //    gameWorldControl.GameWorld[0, 0].GetComponent<TileBehavior>().isSelected = true;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{

        //}
        //if (Input.GetKey(KeyCode.W))
        //{

        //}
        //if (Input.GetKey(KeyCode.S))
        //{

        //}
    }
}
