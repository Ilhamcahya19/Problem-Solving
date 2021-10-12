using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
    // Use this for initialization
    void Start ()
    {
        currentScore = 0;
 
    }

    private void Update() {
        HandleScore ();
    }
 
    private void HandleScore ()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void scoreadd()
    {
        currentScore ++;
    }
    public void scoremin()
    {
        currentScore --;
    }
 
    
}
