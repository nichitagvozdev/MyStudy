using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _secondScreen;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private GameObject currentScreen;

    public Button correctAnswer1;
    public Button correctAnswer2;
    public Button correctAnswer3;
    public Button correctAnswer4;
    public Button correctAnswer5;
    public float score;

    private void Start()
    {
        _menu.SetActive(true);
        currentScreen = _menu;

        Button button1 = correctAnswer1.GetComponent<Button>();
        Button button2 = correctAnswer2.GetComponent<Button>();
        Button button3 = correctAnswer3.GetComponent<Button>();
        Button button4 = correctAnswer4.GetComponent<Button>();
        Button button5 = correctAnswer5.GetComponent<Button>();

        button1.onClick.AddListener(IncrementScore);
        button2.onClick.AddListener(IncrementScore);
        button3.onClick.AddListener(IncrementScore);
        button4.onClick.AddListener(IncrementScore);
        button5.onClick.AddListener(IncrementScore);
    }

    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log(score);
        
        _scoreText.text = "Your score: " + score.ToString() + "/5"; 
    }
}