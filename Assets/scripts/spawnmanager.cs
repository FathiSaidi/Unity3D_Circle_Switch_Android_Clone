using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour {



	 
	public bool can_spawn;

	[SerializeField]
	private GameObject obstacle;
	[SerializeField]
	private GameObject coin;


	// Use this for initialization
	void Start () {
		can_spawn = true;
		StartCoroutine (spawn_obstacle());
		StartCoroutine (spawn_coin());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator spawn_obstacle(){
		if(can_spawn){

			yield return new WaitForSeconds (3.5f);

			int rand_position = Random.Range (0,2);
				
			if(rand_position == 0){
				float randx = Random.Range (-2,3);
				Instantiate (obstacle,transform.position = new Vector2(randx,5.5f),Quaternion.identity);
			} else if(rand_position == 1){
				float randx = Random.Range (-2,3);
				Instantiate (obstacle,transform.position = new Vector2(randx,-5.5f),Quaternion.identity);
			}

			StartCoroutine (spawn_obstacle());
		}
	}
		

	IEnumerator spawn_coin(){
		if(can_spawn){
			yield return new WaitForSeconds (6f);

			int rand_position = Random.Range (0,2);

			if(rand_position == 0){
				float randx = Random.Range (-2,3);
				Instantiate (coin,transform.position = new Vector2(randx,5.5f),Quaternion.identity);
			} else if(rand_position == 1){
				float randx = Random.Range (-2,3);
				Instantiate (coin,transform.position = new Vector2(randx,-5.5f),Quaternion.identity);
			}

			StartCoroutine (spawn_coin());
		}
	}


}
