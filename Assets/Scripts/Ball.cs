using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public bool isRight;
    public float speed;
    private bool speedIncreased = false;
    private bool speedIncreased2 = false;
    private bool speedIncreased3 = false;

    public Transform pointR;
    public Transform pointL;
   
  
    void Start()
    {

    }

   
    void Update()
    {
        IncreaseSpeed();
        //se verdadeiro, vai pra direita
        if(isRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else // se falso, vai pra esquerda
        {
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        //movimento da bola
        if(Vector2.Distance(transform.position, pointL.position) > 0.2f || 
            Vector2.Distance(transform.position, pointR.position) > 0.2f)
            {
                      if(Input.GetMouseButtonDown(0))
                 {
                    isRight = !isRight;
                 }
            }


        //if(Input.GetMouseButtonDown(0))
       // {
       //     isRight = !isRight;
       // }

        if(Vector2.Distance(transform.position, pointL.position) < 0.2f || 
            Vector2.Distance(transform.position, pointR.position) < 0.2f)
        {
            isRight = !isRight;
        }

        //Debug.Log(Time.timeScale);
    }

    public void IncreaseSpeed()
    {
         if (GameController.instance.level == 3 && !speedIncreased)
        {
            speed = 3.2f;
            speedIncreased = true;
        }

         if (GameController.instance.level == 5 && !speedIncreased2)
        {
            speed = 3.5f;
            speedIncreased = false;
            speedIncreased2 = true;
        }

         if (GameController.instance.level == 7 && !speedIncreased3)
        {
            speed = 3.7f;
            speedIncreased = false;
            speedIncreased2 = false;
            speedIncreased3 = true;
        }
    }
}
