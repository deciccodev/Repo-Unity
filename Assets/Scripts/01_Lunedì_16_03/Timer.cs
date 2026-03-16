using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textTimer;
    private float _timer;
    bool _isTimerRunning = false;

    void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isTimerRunning == false)
            {
                _isTimerRunning = true;
            }
            else
                _isTimerRunning = false;
        }

        if (_isTimerRunning == true)
        {
            _textTimer.text = "Timer: " + _timer.ToString("F3");
        }
    }

    void StartTimer()
    {
        if (_isTimerRunning == false)
        {
            _isTimerRunning = true;
        }
        else
            _isTimerRunning = false;
    }

    public void ChiamaStartTimer()
    {
        StartTimer();
    }
}
