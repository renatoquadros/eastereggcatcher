using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Rigidbody2D rig;
    public float speed;   
    private int previousLevel = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0,0, Random.Range(-145,-45)));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
        UpSpeed();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameController.instance.ShowGameOver();
        }
    }

    private void UpSpeed()
    {
        if (GameController.instance.level > previousLevel)
        {
            speed = 2.0f + 0.2f * (GameController.instance.level - 1);
            previousLevel = GameController.instance.level;
       }
    }
}

