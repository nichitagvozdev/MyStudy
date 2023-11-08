using TMPro;
using UnityEngine;

public class TimeHendler : MonoBehaviour
{
    public float currentLop;
    public float currentTime;
    public TMP_Text timerText;
    public TMP_Text LopText;
    public TMP_Text currentLopTimeText;
    public TMP_Text currentLastLopTimeText;
    
    private float _counterCircle = 5;
    private string _currentLopTime;
    private string _currentLastLopTime;
    
    void Update()
    {
        currentTime = Time.time;
        currentTime = Mathf.Round(Time.time);
        timerText.text = currentTime.ToString();

        _currentLastLopTime = _currentLopTime;
    }

    public void clickCircle()
    {
        currentLop++;
        LopText.text = currentLop.ToString();
        
        _currentLopTime = timerText.text ;
        currentLopTimeText.text = _currentLopTime;
        
        currentLastLopTimeText.text = _currentLastLopTime;
    }
}
