using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BASIC_VIECH : MonoBehaviour {

    public int n_Favor;
    public int n_Hunger;
    private bool b_Sleep;
    private float f_Weight;
    public GameObject pref_VIECH;
    public bool b_soweit;

	// Use this for initialization
	void Start ()
    {
        n_Favor = 25;
        n_Hunger = 100;
        b_Sleep = false;
        f_Weight = 0.15f;
    }
	
	// Update is called once per frame
	void Update ()

    {
		if(b_soweit)
        {
           GameObject neuesViech = Instantiate(pref_VIECH);
            VIECH neuesFiechScript = neuesViech.GetComponent<VIECH>();
            //neuesFiechScript.element = 1;// 1 feuer!
            neuesFiechScript.RandomizeThis();
        }
	}

   void TickRated()
    {
        Debug.Log("Ticked");
        if(n_Favor > 0)
            n_Favor--;
        if(n_Hunger >0)
           n_Hunger--;
    }
}
