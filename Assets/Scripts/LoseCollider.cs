using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	// Use this for initialization
	private LevelManager levelManager;

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Ouch! - " + collision.gameObject.name.ToString());
		levelManager.LoadLevel ("Winner");
	}
	void OnTriggerEnter2D(Collider2D colliderObject){
		Debug.Log ("Triggered! - " + colliderObject.name);
		levelManager.LoadLevel ("Winner");
	}

}
