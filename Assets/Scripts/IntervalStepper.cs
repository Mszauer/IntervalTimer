using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntervalStepper : MonoBehaviour {
    public Text timer;
    public Text totalTimeSec;
    public Text totalTimeMin;

    public int deltaStepper = 5;
    int maxValue = 960;
    int minValue = 0;
    int stepperValue = 0;
    int totalSecVal = 0;
    int totalMinVal = 0;
    int rounds = 1;

    public void IncreaseStepper() {
        totalSecVal = System.Convert.ToInt32(totalTimeSec.text);
        totalMinVal = System.Convert.ToInt32(totalTimeMin.text);
        if (stepperValue < maxValue) {
            stepperValue += deltaStepper;
        }
        timer.text = stepperValue.ToString();
        if (totalSecVal < 60) {
            totalSecVal += deltaStepper;
        }
        else {
            totalSecVal = 0;
            totalMinVal++;
        }
        totalTimeSec.text = totalSecVal.ToString("D2");
        totalTimeMin.text = totalMinVal.ToString();
    }
    public void DecreaseStepper() {
        if (stepperValue > minValue) {
            stepperValue -= deltaStepper;
        }
        timer.text = stepperValue.ToString();
        if (totalSecVal > 0) {
            totalSecVal -= deltaStepper;
        }
        else if (System.Convert.ToInt32(timer.text) >0){
            totalSecVal = 55;
            if (totalMinVal > 0) {
                totalMinVal--;
            }
        }
        totalTimeSec.text = totalSecVal.ToString("D2");
        totalTimeMin.text = totalMinVal.ToString();
    }
    public void IncreaseRounds() {
        rounds++;
        int roundSec = totalSecVal * rounds;
        int roundMin = totalMinVal * rounds + (roundSec/60);
        roundSec -= (roundSec / 60);
        timer.text = rounds.ToString();
        totalTimeSec.text = roundSec.ToString("D2");
        totalTimeMin.text = roundMin.ToString();
    }
}
