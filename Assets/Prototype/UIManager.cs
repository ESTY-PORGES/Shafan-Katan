using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text ScoreText;
    [SerializeField] private Text HealthText;

    [SerializeField] private GameManager gameManager;


    private void Start()
    {
        gameManager.OnScoreChanged += ChangeScoreText;
        gameManager.OnWrongClick += ChangeHealthText;
    }
    
    private void ChangeScoreText(int score)
    {
        ScoreText.text = score.ToString();
    }

    private void ChangeHealthText(int health)
    {
        HealthText.text = health.ToString();
    }



}
