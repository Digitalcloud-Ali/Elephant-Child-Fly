using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Setup : MonoBehaviour {

    void Awake() {
        useGUILayout = false;
        if(Application.platform == RuntimePlatform.IPhonePlayer) {
            Application.targetFrameRate = 60;
        }
        AudioListener.volume = PlayerPrefs.GetInt("volume", 50);
    }

    void Start() {
        if(System.String.Compare(Application.loadedLevelName, "game_over") == 0) {
        }
    }
	
	void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
                Application.Quit();
        }
        if(Application.platform == RuntimePlatform.IPhonePlayer) {
            if(Time.frameCount % 30 == 0) {
                System.GC.Collect();
            }
        }
	}

    void OnApplicationQuit() {
        #if UNITY_ANDROID
        #endif
    }

    void OnApplicationPause(bool paused) {
        #if UNITY_ANDROID
        #endif
    }

}
