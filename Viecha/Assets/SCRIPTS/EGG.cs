using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGG : MonoBehaviour
{
    public GameObject pref_spawn;
    private GameObject go_world;
    // Use this for initialization
    void Start()
    {

        go_world = transform.parent.gameObject;



    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.touchCount);
        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                Debug.Log("Ei geschlüpft");
                Instantiate(pref_spawn,go_world.transform);
                Destroy(gameObject);

            }
        }
    }
}
