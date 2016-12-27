using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3 (Mathf.Clamp((Input.mousePosition.x / Screen.width * 16) - 8.5f, - 8, 7 ), -5f, -6f);

        gameObject.transform.position = paddlePos;
	}
}
