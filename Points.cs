using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public CircleCollider2D jumperCol;
    public BoxCollider2D pointCol;
    public GameObject point;
    public Jumper jumper;


    void Update()
    {
        if (jumperCol.IsTouching(pointCol))
        {
            point.SetActive(false);
            jumper.points += 1;
        }
    }
}
