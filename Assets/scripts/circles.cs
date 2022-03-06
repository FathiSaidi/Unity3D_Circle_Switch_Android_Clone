using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circles : MonoBehaviour {


	private gamemanager gm;




	// Use this for initialization
	void Start () {
		gm = GameObject.Find("game_manager").GetComponent<gamemanager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target){
		if(target.gameObject.tag == "coin"){
			gm.update_score ();
			Destroy (target.gameObject);
		} else if(target.gameObject.tag == "enemy"){
			gm.game_over ();
		}
	}
}
