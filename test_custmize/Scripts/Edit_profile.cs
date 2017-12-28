using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Edit_profile : MonoBehaviour {

    public GameObject in_name;
    public GameObject out_name;
    public GameObject in_notes;
    public GameObject out_notes;
    public GameObject in_gender;
    public GameObject out_gender;

	// Use this for initialization
	void Start () {
		
	}
	
    public void OnClick()
    {
        out_name.GetComponent<Text>().text = in_name.GetComponent<Text>().text;
        out_notes.GetComponent<Text>().text = in_notes.GetComponent<Text>().text;
        out_gender.GetComponent<Text>().text = in_gender.GetComponent<Dropdown>().captionText.text;
    }
}
