using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {

	[SerializeField]
	private Text score_ui;
	[SerializeField]
	private int score;
	[SerializeField]
	private GameObject pivot;
	[SerializeField]
	private GameObject ui_panel;
	[SerializeField]
	private GameObject obstacle;
	[SerializeField]
	private GameObject coin;


	private spawnmanager sm;

	// Use this for initialization
	void Start () {
		sm = GameObject.Find("spawn_manager").GetComponent<spawnmanager> ();
		score_ui.text = "00";
		ui_panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void update_score(){
		score += 10;
		score_ui.text = score.ToString ();
	}

	public void game_over(){
		Destroy (pivot.gameObject);
		sm.can_spawn = false;
		ui_panel.SetActive (true);
	}

	public void load_scene(){
		SceneManager.LoadScene (0);
	}
		
}
