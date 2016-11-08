using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;


	// Use this for initialization
	void Start () {
	
		//get camera position - the position of the ball
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	// LateUpdate run after items have been updated
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
