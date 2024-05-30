using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musics : MonoBehaviour
{
    public AudioSource musicaDeFundo;    
   
    public void TocarMusicaDeFundo()
    {
       musicaDeFundo.Play();
    }
   
}
