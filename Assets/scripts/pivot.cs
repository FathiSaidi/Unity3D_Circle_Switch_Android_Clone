using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivot : MonoBehaviour {

	private float speed = 3.4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0,speed);
	}

	public void Switch_Rotation(){
		speed *= -1;
	}
}
