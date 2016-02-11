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
    int totalMinVal {
        get {
            return (totalSecVal % 3600) / 60;
        }
    }
    int rounds = 1;

    public void IncreaseStepper() {
        totalSecVal = System.Convert.ToInt32(totalTimeSec.text);
        if (stepperValue < maxValue) {
            stepperValue += deltaStepper;
            totalSecVal += deltaStepper;
        }
        timer.text = stepperValue.ToString();
        totalTimeSec.text = totalSecVal.ToString("D2");
        totalTimeMin.text = totalMinVal.ToString();
    }
    public void DecreaseStepper() {
        if (stepperValue > minValue) {
            stepperValue -= deltaStepper;
            totalSecVal -= deltaStepper;
        }
        timer.text = stepperValue.ToString();
        totalTimeSec.text = totalSecVal.ToString("D2");
        totalTimeMin.text = totalMinVal.ToString();
    }
    public void IncreaseRounds() {
        rounds++;
        float roundSeconds = totalSecVal * rounds;
        timer.text = rounds.ToString();
    }
}
