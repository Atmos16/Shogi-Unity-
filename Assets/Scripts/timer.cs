using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public float time_limit;
    private double minute;
    private double hour;
    private float second;
    private string display_limit;

    public GameObject destroyed_button;
    public GameObject over_info;
    private GameObject play_window;

	// Use this for initialization
	void Start () {
        play_window = GameObject.Find("Play_window");
	}
	
	// Update is called once per frame
	void Update () {

        time_limit -= Time.deltaTime;
        Time_over();

        minute = Math.Floor(time_limit / 60);
        hour = Math.Floor(minute / 60);
        second = time_limit % 60;
        display_limit = hour.ToString("00") + "h"
                      + minute.ToString("00") + "m"
                      + second.ToString("00.00") + "s";
        gameObject.GetComponent<Text>().text = display_limit;
	}

    void Time_over()
    {
        if (time_limit < 0)
        {
            Destroy(destroyed_button);
            time_limit = 0;
            enabled = false;
            GameObject.Instantiate(over_info, play_window.transform);
        }
    }
}

//機能
//・ゲームオーバー
//・pause機能