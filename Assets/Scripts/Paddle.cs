using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPaddlePosition = new Vector3(0.5f, 0.365f,0f);

		//newPaddlePosition.Set (Mathf.Max(0,Mathf.Min (15,(Input.mousePosition.x / Screen.width *16))),.365f,0f);
		newPaddlePosition.x = Mathf.Clamp(Input.mousePosition.x / Screen.width *16,0f,15f);
		this.transform.position = newPaddlePosition;
	}
}
