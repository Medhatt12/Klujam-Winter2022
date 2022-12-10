using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehavior : MonoBehaviour
{
    public int maxNumberOfPoints = 9;
    public int numOfPlayer1fishes = 0;
    public int hiddenAttribute;
    public bool isSelected;
    [SerializeField] GameObject selectedBox;
    bool once = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (maxNumberOfPoints >0 && Timer.instance.timeRemaining>0)
        {
            numOfPlayer1fishes = numOfPlayer1fishes + 1;
            maxNumberOfPoints = maxNumberOfPoints - 1;
            pointsManager.instance.losePoint();
            this.GetComponent<SpriteRenderer>().color = Color.blue;
            //Instantiate(selectedBox, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f), Quaternion.identity);
            Debug.Log("Hidden attribute for this tile is: " + hiddenAttribute);
        }
        
       
    }
    void OnMouseUp()
    {
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
