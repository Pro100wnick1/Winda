using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public GameObject[] waypoints;
    public float speed;
    int current;
 
    
    public void MoveTo0()
    {
        current = 0;
            transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
    public void MoveTo1st()
    {
        current = 1;
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
    public void MoveTo2nd()
    {
        current = 2;
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
    public void MoveTo3th()
    {
        current = 3;
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
    public void MoveTo4th()
    {
        current = 4;
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }

    /* private Rigidbody2D rb;
     private float moveSpeed;

     private void Start()
     {
         rb = GetComponent<Rigidbody2D>();
         moveSpeed = 5;
     }

     // Update is called once per frame
     public void MoveUp()
     {
         rb.velocity = Vector2.up * moveSpeed;
     }
     public void StopMoving()
     {
         rb.velocity = Vector2.zero;
     }*/
}
