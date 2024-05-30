using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed; 
    public AudioSource coin;
 

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            coin.Play(); 
            GameController.instance.AddScore();
            GameController.instance.ColetarOvo(); 
            GameController.instance.zerarScore = 1;           
            if(GameController.instance.level == 10){GameController.instance.ShowGameEnd();}                       
            //Destroy(gameObject);

            // Aguarde um curto período antes de destruir o objeto
            StartCoroutine(DestroyCollectableWithDelay());
        }
        else if(collision.CompareTag("ZerarScore"))
        {
          GameController.instance.ZerarOScore();
          StartCoroutine(DestroyCollectableWithDelay());
        }
        
    }
  

    IEnumerator DestroyCollectableWithDelay()
    {
        yield return new WaitForSeconds(0.07f); // Ajuste este valor conforme necessário
        Destroy(gameObject);
    }
}
