using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float Up = (5f);
    [SerializeField] float Stop = (0f);
    [SerializeField] float Left = (-5f);
    [SerializeField] float Right = (5f);
    [SerializeField] float Down = (-5f);

    Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();

        Target();    

    }
    void Movement()
    {
        //Move Up
        if (Input.GetKey(KeyCode.W))
        {
            rd.velocity = new Vector2(0, Up);
            Debug.Log("W Pressed");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rd.velocity = new Vector2(0, Stop);
            Debug.Log("W Let go");
        }
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            rd.velocity = new Vector2(Left, 0);
            Debug.Log("A Pressed");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rd.velocity = new Vector2(0, Stop);
            Debug.Log("A Let go");
        }
        //Move Down
        if (Input.GetKey(KeyCode.S))
        {
            rd.velocity = new Vector2(0, Down);
            Debug.Log("S Pressed");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rd.velocity = new Vector2(0, Stop);
            Debug.Log("S Let go");
        }
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            rd.velocity = new Vector2(Right, 0);
            Debug.Log("D Pressed");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rd.velocity = new Vector2(0, Stop);
            Debug.Log("D Let go");
        }
    }

    void Target()
    {




    }
}


