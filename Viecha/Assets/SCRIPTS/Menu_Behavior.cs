using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Behavior : MonoBehaviour {

    public GameObject flashText;

	// Use this for initialization
	void Start ()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        InvokeRepeating("flashTheText", 0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount == 1)
        {
            
            SceneManager.LoadScene("Game_Scene");
        }
    }
    void flashTheText()
    {
        if (flashText.activeInHierarchy)
            flashText.SetActive(false);
        else
            flashText.SetActive(true);
         
    }
}
