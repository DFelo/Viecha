using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOODMENU_SCRIPT : MonoBehaviour {

    public Sprite foodPic;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickHamburger()
    {
        CreateFood(0);
    }

    public void OnClickSalad()
    {
        CreateFood(1);
    }

    public void OnClickPizza()
    {
        CreateFood(2);
    }

    void CreateFood(int foodType)
    {
        GameObject food = new GameObject();
        SpriteRenderer sr =food.AddComponent<SpriteRenderer>();
        Sprite foodSprite = new Sprite();
        sr.sprite =

        switch(foodType)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
}
