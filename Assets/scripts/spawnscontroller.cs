using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscontroller : MonoBehaviour {

	private float move_speed;


	// Use this for initialization
	void Start () {
		move_direction ();
	}
	
	// Update is called once per frame
	void Update () {
		movement ();
		limit_corners ();
	}

	public void movement(){
		transform.Translate (Vector2.up * Time.deltaTime * move_speed);
	}
		
	public void limit_corners(){
		if(transform.position.y > 8){
			Destroy (this.gameObject);
		} else if(transform.position.y < -8){
			Destroy (this.gameObject);	
		}
	}

	public void move_direction(){
		
		if(transform.position.y > 0){
			move_speed = -2.55f;
		} else if(transform.position.y < 0){
			move_speed = 2.55f;
		}

	}


}
