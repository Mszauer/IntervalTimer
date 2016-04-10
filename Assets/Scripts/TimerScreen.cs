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
    protected float internalWork = 0f;
    protected float internalRest = 0f;

    public float work {
        get {
            return internalWork;
        }
        set {
            internalWork = value;
            int _work = (int)value;
            Work.text = _work.ToString("D2");
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
    public float rest {
        get {
            return internalRest;
        }
        set {
            internalRest = value;
            int _rest = (int)value;
            Rest.text = _rest.ToString("D2");
        }
    }
    public System.DateTime TimeFinished { get; set; }

    public void Update() {
        if (work > 0) {
            work -= Time.deltaTime;
        }
        else if (rest > 0) {
            rest -= Time.deltaTime;
        }
        else if (rounds > 1) {
            rounds--;
            work = defaultWork;
            rest = defaultRest;
        }
        else {
            //switch scene
            ScreenChanger changer = Camera.main.GetComponent<ScreenChanger>();
            changer.Finish();
        }
        int DisplaySeconds = (TimeFinished - System.DateTime.UtcNow).Seconds;
        int DisplayMinutes = (TimeFinished - System.DateTime.UtcNow).Minutes;
        TotalTime.text = DisplayMinutes.ToString("D2") +" : "+ DisplaySeconds.ToString("D2");
        
    }

}
