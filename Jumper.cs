using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class Jumper : MonoBehaviour
{
    public float speed = 0f;
    public float maxSpeed = 9f;
    public float speedUp = 0.45f;


    public float jumpHeight = 0f;
    public float MaxJumpHeight = 14f;
    public bool canJump;

    public Rigidbody2D rb;
    public CircleCollider2D jumperCollider;

    public Camera cam;
    public Transform camPos;
    public Transform jumperPos;
    public bool isGameOver;

    public int points = 0;
    public Text pointsTxt;


    void Start()
    {
        canJump = true;
        isGameOver = false;
    }

    void Update()
    {
        pointsTxt.text = "> POINTS: " + points + " <";
        

        if(isGameOver==false)
            CameraLock();

        if (speed > maxSpeed)
            speed = maxSpeed;

        if (jumpHeight > MaxJumpHeight)
            jumpHeight = MaxJumpHeight;
        transform.rotation = Quaternion.Euler(0, 0, 0);

        if (Input.GetKey(KeyCode.T) && canJump)
        {
            
            jumpHeight = 9f + (speed/2.5f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, +jumpHeight);
            canJump = false;
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            jumpHeight = 0f;
        }


        if (Input.GetKey(KeyCode.H))
        {
            speed += speedUp;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
            
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {

            speed = 0f;
        }

        if (Input.GetKey(KeyCode.F))
        {
            speed += speedUp;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
            
        }
        else if (Input.GetKeyUp(KeyCode.F))
        {
            speed = 0f;

        }

    }
    public void CameraLock()
    {
        camPos.position = new Vector3(-0.6274435f, jumperPos.position.y, -12f);
    }
    
}
