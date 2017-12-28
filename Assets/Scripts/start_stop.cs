using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_stop : MonoBehaviour {

    string state;
    string stop;
    string start;
    public timer timer;

    private void Start()
    {
        stop = "Stop";
        start = "Start";
        state = start;

        gameObject.GetComponent<Text>().text = stop;
        state = stop;
        timer.enabled = true;
    }

    public void OnClick()
    {
        switch (state)
        {
            case "Start":
                gameObject.GetComponent<Text>().text = stop;
                state = stop;
                timer.enabled = true;
                break;

            case "Stop":
                gameObject.GetComponent<Text>().text = start;
                state = start;
                timer.enabled = false;
                break;
        }
    }


}
