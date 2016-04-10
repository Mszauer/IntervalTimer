﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntervalStepper : MonoBehaviour {
    public Text timer;
    public Text TotalTime;

    int deltaStepper = 5;
    int maxValue = 960;
    int minValue = 0;
    int stepperValue = 0;
    static int totalSecVal = 0;
    static int rounds = 1;
    static int warmUp = 0;
    static int coolDown = 0;

    public void IncreaseWarmup() {
        if (stepperValue < maxValue) {
            stepperValue += deltaStepper;
            warmUp += deltaStepper;
        }
        timer.text = stepperValue.ToString();
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void DecreaseWarmup() {
        if (stepperValue > minValue) {
            stepperValue -= deltaStepper;
            warmUp -= deltaStepper;
        }
        timer.text = stepperValue.ToString();
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void IncreaseCoolDown() {
        if (stepperValue < maxValue) {
            stepperValue += deltaStepper;
            coolDown += stepperValue;
        }
        timer.text = stepperValue.ToString();
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void DecreaseCoolDown() {
        if (stepperValue > minValue) {
            stepperValue -= deltaStepper;
            coolDown -= deltaStepper;
        }
        timer.text = stepperValue.ToString();
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void IncreaseStepper() {
        if (stepperValue < maxValue) {
            stepperValue += deltaStepper;
            totalSecVal += deltaStepper;
        }
        timer.text = stepperValue.ToString();
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void DecreaseStepper() {
        if (stepperValue > minValue) {
            stepperValue -= deltaStepper;
            totalSecVal -= deltaStepper;
        }
        timer.text = stepperValue.ToString();
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void IncreaseRounds() {
        rounds++;
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        timer.text = rounds.ToString();
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
    public void DecreaseRounds() {
        rounds--;
        if (rounds <= 0) {
            rounds = 1;
        }
        int localtotalSecVal = totalSecVal * rounds + warmUp + coolDown;
        timer.text = rounds.ToString();
        int minutes = (localtotalSecVal / 60);
        int seconds = localtotalSecVal - (minutes * 60);
        TotalTime.text = minutes.ToString("D2") + " : " + seconds.ToString("D2");
    }
}
