using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHit;
    private int timesHit = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timesHit == maxHit)
            Destroy(gameObject);
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision" + collision.gameObject.GetType());
        if (collision.gameObject.tag == "Player")
            timesHit++;
    }
}
