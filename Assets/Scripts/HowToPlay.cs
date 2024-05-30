using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public static HowToPlay instance;

    public GameObject pauseGame;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 

    public void StartTheGame()
    {
        
       Time.timeScale = 1;             
       this.gameObject.SetActive(false);
       pauseGame.SetActive(true); 
    }
}
