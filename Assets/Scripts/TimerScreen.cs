using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScreen : MonoBehaviour {
    public Text TotalTime = null;
    public Text Rounds = null;
    public Text Work = null;
    public Text Rest = null;
    public int defaultRest = 0;
    public int defaultWork = 0;
    
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
    public int rest {
        get {
            return System.Convert.ToInt32(Rest.text);
        }
        set {
            Rest.text = value.ToString("D2");
        }
    }
    public System.DateTime TimeFinished { get; set; }

    public void Update() {
        //seconds work
        //subtract one from the value each second (apply dTime to stabalize)
        //once it hits 0, start rest timer
        //seconds of rest
        //subtract one from the value each second (apply dTime to stabalize)
        //once it hits 0, decrement round by 1
        //once round gets decremented, set seconds work and rest to default values
        int DisplaySeconds = (TimeFinished - System.DateTime.UtcNow).Seconds;
        int DisplayMinutes = (TimeFinished - System.DateTime.UtcNow).Minutes;
        TotalTime.text = DisplayMinutes.ToString("D2") +" : "+ DisplaySeconds.ToString("D2");
    }

}
