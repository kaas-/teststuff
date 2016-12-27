using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    public paddle mPaddle;

    private Vector3 paddleToBallVector;
    private bool mouseClicked = false;
    private Rigidbody2D rigidbody2D;

	// Use this for initialization
    void Awake ()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

	void Start ()
    {
        paddleToBallVector = gameObject.transform.position - mPaddle.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.GetMouseButtonDown(0))
        {
            mouseClicked = true;

            rigidbody2D.velocity = new Vector2(Random.Range(-12f, 12f), 12f);
        }

        if(!mouseClicked)
        {
            gameObject.transform.position = mPaddle.transform.position + paddleToBallVector;
        }

	}
}
