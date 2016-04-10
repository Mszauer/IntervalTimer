using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenChanger : MonoBehaviour {
    public GameObject StartScreen = null;
    public GameObject TimerScene = null;
    public TimerScreen TimerScreen = null;
    public Text totalTimeSec;
    public Text totalTimeMin;

    public void Awake() {
        StartScreen.SetActive(true);
        TimerScene.SetActive(false);
    }
    public void StartClicked() {
        StartScreen.SetActive(false);
        TimerScene.SetActive(true);
        int totalSeconds = System.Convert.ToInt32(totalTimeSec.text) + (System.Convert.ToInt32(totalTimeMin.text) * 60);
        TimerScreen.TimeLeft = System.DateTime.UtcNow.AddSeconds(totalSeconds);
    }
}
