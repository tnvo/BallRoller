using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; 
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
	//where physics code will go
		float moveHorizontal = Input.GetAxis("Horizontal"); 
		float moveVertical = Input.GetAxis("Vertical");

		//create movement with x, y, z
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//see vector 3 above
		rb.AddForce (movement * speed);
	
		}


}
