using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	// Use this for initialization
	public LevelManager levelManager;

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Ouch! - " + collision.gameObject.name.ToString());
		levelManager.LoadLevel ("Winner");
	}
	void OnTriggerEnter2D(Collider2D colliderObject){
		Debug.Log ("Triggered! - " + colliderObject.name);
		levelManager.LoadLevel ("Winner");
	}

}
