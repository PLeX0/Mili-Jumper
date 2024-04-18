using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropper : MonoBehaviour
{
    public GameObject dropper;
    public GameObject strips;
    public float timer;
    public float dropper_y;
    public Rigidbody2D rg;
    
    void Update()
    {



        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if(timer <= 0)
        {
            Instantiate(strips, new Vector3(Random.Range(-5f, 5f), rg.position.y + 10f), Quaternion.identity);
            strips.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
            timer = 5f;
        }
    }
}
