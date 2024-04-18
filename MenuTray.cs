using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTacki : MonoBehaviour
{

    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -60); 
    }
}
