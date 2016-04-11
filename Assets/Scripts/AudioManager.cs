using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour {
    [System.Serializable]
    public class AudioData {
        public string name;
        public AudioSource audio = null;
    }
    public List<AudioData> SoundBank = null;
    
    public static AudioManager Instance { get; protected set; }

	void Awake () {
        Instance = this;

	}
	public void PlaySound(string soundName) {
        for (int i = 0; i < SoundBank.Count; i++) {
            if (SoundBank[i].name == soundName) {
                SoundBank[i].audio.PlayOneShot(SoundBank[i].audio.clip);
            }
        }
    }
}
