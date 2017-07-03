using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIECH : MonoBehaviour {

    public int element;
    private bool soweit;
    public GameObject pref_Monster;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(soweit)
        {
            Spawn();
        }
	}

    public void RandomizeThis()
    {
        //randomizing shit
    }

    public void CreateFromMother(GameObject mother)
    {
        //werte von mutter prüfen und neue Setzen


        

        //aussehen setzen!
    }

    void Spawn()
    {
        GameObject neuesViech = Instantiate(pref_Monster);
        VIECH neuesFiechScript = neuesViech.GetComponent<VIECH>();
        //neuesFiechScript.element = 1;// 1 feuer!
        neuesFiechScript.CreateFromMother(gameObject);
    }

    
}
