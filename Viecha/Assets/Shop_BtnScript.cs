using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_BtnScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void OnClick()
    {
        GameObject Clockmaster = GameObject.FindGameObjectWithTag("Clockmaster");
        CLOCK_SCRIPT clockscript = Clockmaster.GetComponent<CLOCK_SCRIPT>();
        clockscript.Shop_Menu.SetActive(true);
    }
}
