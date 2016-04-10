using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenChanger : MonoBehaviour {
    public GameObject StartScene = null;
    public TimerScreen StartScreen = null;

    public GameObject TimerScene = null;
    public TimerScreen TimerScreen = null;

    public GameObject FinishedScene = null;
    public TimerScreen FinishedScreen = null;

    public Text totalTimeSec;

    public void Awake() {
        StartScene.SetActive(true);
        TimerScene.SetActive(false);
    }
    public void StartClicked() {
        StartScene.SetActive(false);
        TimerScene.SetActive(true);
        TimerScreen.rest = IntervalStepper.rest;
        TimerScreen.work = IntervalStepper.work;
        TimerScreen.defaultRest = IntervalStepper.rest;
        TimerScreen.defaultWork = IntervalStepper.work;
        TimerScreen.rounds = IntervalStepper.rounds;
        string[] splitTime = totalTimeSec.text.Split(':');
        int min = System.Convert.ToInt32(splitTime[0]);
        int sec = System.Convert.ToInt32(splitTime[1]);
        int totalSeconds = sec + (min * 60);
        TimerScreen.TimeFinished = System.DateTime.UtcNow.AddSeconds(totalSeconds);
    }
    public void HomeClicked() {
        TimerScene.SetActive(false);
        StartScene.SetActive(true);

    }
}
