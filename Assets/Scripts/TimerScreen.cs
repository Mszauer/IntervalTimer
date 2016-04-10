using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScreen : MonoBehaviour {
    public Text TotalTime = null;
    public Text Rounds = null;
    public Text Work = null;
    public int work {
        get {
            return System.Convert.ToInt32(Work.text);
        }
        set {
            Work.text = value.ToString("D2");
        }
    }
    public int rounds {
        get {
            return System.Convert.ToInt32(Rounds.text);
        }
        set {
            Rounds.text = value.ToString("D2");
        }
    }
    public System.DateTime TimeLeft { get; set; }

    public void Update() {
        
        int DisplaySeconds = (TimeLeft - System.DateTime.UtcNow).Seconds;
        int DisplayMinutes = (TimeLeft - System.DateTime.UtcNow).Minutes;
        TotalTime.text = DisplayMinutes.ToString("D2") +" : "+ DisplaySeconds.ToString("D2");
    }
}
