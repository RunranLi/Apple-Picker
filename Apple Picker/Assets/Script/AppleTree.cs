/**
 * Created by: Runran Li
 * Date Created: Jan 31,2022
 * Last Edited by: NA
 * Description: Controls the movement of the AppleTree
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
        // Dropping apples every second    
    {
         InvokeRepeating( "DropApple", 2f, secondsBetweenAppleDrops );
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //set speed to positive
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //set spped to negative value
        } //end Change Direction
       
    }

    void FixedUpdate()
    {
        //Test chance of direction change
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; // change directions
        }
    }//end FixedUpdate()
}
