using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	bool launched = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!launched) this.transform.position = paddle.transform.position + paddleToBallVector;

		if(!launched && Input.GetMouseButtonDown(0)) {
			print ("Launching ball - mouse down detected");
			this.rigidbody2D.velocity = new Vector2(2f,10f);
			launched = true;
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if(collision.gameObject.name == "Paddle"){
			print("Hit the paddle...");
		}
	}
}
