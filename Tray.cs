using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class Tacka : MonoBehaviour
{

    public BoxCollider2D trayCollider;
    public BoxCollider2D feetCollider;
    public BoxCollider2D headCollider;
    public CircleCollider2D jumperCollider;
    public BoxCollider2D gc;
    public BoxCollider2D destroyer;
    public GameObject tray;
    public Jumper jumper = new Jumper();
    public Transform deathLine;
    public BoxCollider2D deathLineCol;
    public GameObject gameOver;
    public bool jumpBoost = false;

  

    void Start()
    {
        
        jumper.canJump = true;
    }


    void Update()
    {
        Jump_Boost();
        Destroy_Tray();
        GameOver();
        if (feetCollider.IsTouching(trayCollider) && !jumperCollider.IsTouching(trayCollider))
        {
            trayCollider.isTrigger = false;
        }
        if (headCollider.IsTouching(trayCollider))
        {
            trayCollider.isTrigger = true;
        }

        Ground_Check();

    }
    public void Ground_Check()
    {
        if (jumper.canJump == false && gc.IsTouching(trayCollider) && jumper.jumpHeight == 0)
        {
            jumper.canJump = true;
        }
        else if(!jumper.canJump == false && gc.IsTouching(trayCollider) && jumper.jumpHeight == 0)
        {
            jumper.canJump = false;
        }
           
    }

    public void Destroy_Tray()
    {
        if(trayCollider.IsTouching(destroyer) && !jumpBoost)
        {
            tray.SetActive(false);
            deathLine.transform.position = new Vector3(0, tray.transform.position.y, 0f);
        }
    }

    public void GameOver()
    {
        
        if(jumperCollider.IsTouching(deathLineCol))
        {
            jumper.isGameOver = true;        
        }

        if(jumper.isGameOver==true)
        {
            gameOver.SetActive(true);
            jumper.camPos.position = new Vector3(-0.6274435f, deathLine.position.y, -12f);
        }
    }
    
    public void Jump_Boost()
    {
        if(jumperCollider.IsTouching(trayCollider) && jumpBoost == true)
        {
            jumper.canJump = false;
            jumper.GetComponent<Rigidbody2D>().velocity += new Vector2(0f, 1.3f);

        }

        
    }

    
}
