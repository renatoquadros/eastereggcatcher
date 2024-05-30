using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   public Text scoreText; 
   public Text levelText;  
   public Text textoDeHighScore;
   public Text YourScoreText;
   public Text YourFinalScoreText;
   public Text YourFinalHighScoreText;
   public GameObject gameOver;
   public GameObject endGame;
   public GameObject PauseGame;
   

   public int ovosColetados = 0;
   public int ovosPorNivel = 10;

   public static GameController instance;
   public int score;
   public int level;

   public int zerarScore;

   void Start()
   {
        level = 1;
        score = 0;
        zerarScore = 1;
        scoreText.text = "SCORE: " + score.ToString();
        levelText.text = "LEVEL: " + level;

   }
   
   private void Awake()
   {
        instance = this;       
        Time.timeScale = 1;
   }

   public void ShowGameOver()
   {
        gameOver.SetActive(true);
        PauseGame.SetActive(false);
        Time.timeScale = 0;  

        YourScoreText.text = "Your Score: " + score;      

        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", (int)score);
        }

        textoDeHighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");
   }

   public void ShowGameEnd()
   {
       
            endGame.SetActive(true);
            Time.timeScale = 0;

            YourFinalScoreText.text = "Your Final Score: " + score;      

            if(score > PlayerPrefs.GetInt("HighScore"))
            {
            PlayerPrefs.SetInt("HighScore", (int)score);
            }

            YourFinalHighScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");        
        
   }
    
    public void RestartGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void RestartGame2()
    {
        //Debug.Log("Botão pressionado");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void AddScore()
    {
        if(score == 0 || zerarScore == 0) score += 1;
        else{
        score = score += 1 * level;
        }
        scoreText.text = "SCORE: " + score.ToString();
    }   

    /*public void AddLevel()
    {
        if(GameController.instance.score > 0 && GameController.instance.score % 10 == 0 && level < 11)
            {
                level += 1;
                levelText.text = "NÍVEL: " + level;
            }     
    }*/

    public void ColetarOvo()
    {
        
        ovosColetados++;
        

        if (ovosColetados >= ovosPorNivel)
        {
            SubirDeNivel();
        }
    }

    public void SubirDeNivel()
    {
        level++;
        levelText.text = "NÍVEL: " + level;
        ovosColetados = 0;
        //Debug.Log("Parabéns! Você subiu para o nível " + nivelAtual);
        // Adicione aqui qualquer ação adicional que você deseja realizar ao subir de nível
    }

    public void ZerarOScore()
    {
        zerarScore = 0;
    }
    
}
