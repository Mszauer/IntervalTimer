using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScreen : MonoBehaviour {
    public Text TotalTime = null;
    public int Rounds {
        get; set;
    }
    public int Work { get; set; }
    public System.DateTime TimeFinished { get; set; }
    public void Update() {
        int DisplaySeconds = (TimeFinished - System.DateTime.UtcNow).Seconds;
        int DisplayMinutes = (TimeFinished - System.DateTime.UtcNow).Minutes;
        TotalTime.text = DisplayMinutes.ToString("D2") +" : "+ DisplaySeconds.ToString("D2");
    }
}
