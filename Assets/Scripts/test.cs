    //this is the ball script
using UnityEngine;
using System.Collections;
    public class test : MonoBehaviour
{
    public float speed = 30;

    void start()
    {

        //Initial Velocity 
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
}





