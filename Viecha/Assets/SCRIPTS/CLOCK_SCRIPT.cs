using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CLOCK_SCRIPT : MonoBehaviour
{

    private int n_FrameCounter;
    private const int n_Framelock = 30;
    private DateTime_Script Currenttime;
    private GameObject go_world;
    public GameObject Shop_Menu;
    // Use this for initialization
    void Start()
    {

        Shop_Menu = GameObject.FindGameObjectWithTag("Shop_Menu");
        Shop_Menu.SetActive(false);


        go_world = transform.parent.gameObject;
        QualitySettings.vSyncCount = 0;
        Currenttime = new DateTime_Script();
        Currenttime.SetTime(System.DateTime.Now);
        Application.targetFrameRate = n_Framelock;
        n_FrameCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (n_FrameCounter == n_Framelock)
        {
            Currenttime.increaseSeconds();
            Currenttime.DebugTime();
            go_world.BroadcastMessage("TickRated",SendMessageOptions.RequireReceiver);
            //TODO SHIT
            n_FrameCounter = 0;
        }
        else
            n_FrameCounter++;

        Debug.Log(Input.touchCount);
        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log("Ei geschlüpft");

                Destroy(gameObject);

            }
        }


    }
}
