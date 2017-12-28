using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time_over : MonoBehaviour {
    public timer timer;
    public GameObject destroyed_object;
    public GameObject over_info;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timer.time_limit < 0)
        {
            Destroy(destroyed_object);
            timer.time_limit = 0;
            timer.enabled = false;
            GameObject.Instantiate(over_info);
        }
	}
}
