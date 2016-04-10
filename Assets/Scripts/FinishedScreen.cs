using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinishedScreen : MonoBehaviour{
    public Text totalTime = null;
    public Text Rounds = null;
    public Text Rest = null;
    public Text Work = null;
    public int work {
        get {
            return System.Convert.ToInt32(Work.text);
        }
        set {
            Work.text = value.ToString("D2");
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
}

