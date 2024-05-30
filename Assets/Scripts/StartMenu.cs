using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
     // Start is called before the first frame update
    public GameObject howtoplay;

    void Start()
    {
        Time.timeScale = 0;     
        FindObjectOfType<Musics>().TocarMusicaDeFundo();   
    }  

    public void IniciarJogo()
    {
       //Time.timeScale = 1f; 
       this.gameObject.SetActive(false);
       howtoplay.SetActive(true);

    }

   
}
