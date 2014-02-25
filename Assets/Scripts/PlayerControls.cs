using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	float ratationSpeed = 100f;
	float moveSpeed = 1000f;
	float jumpHeight = 30000f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// Rotating
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(new Vector3(0, -ratationSpeed * Time.deltaTime, 0));
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(new Vector3(0, ratationSpeed * Time.deltaTime, 0));
		}
		else {
			rigidbody.angularVelocity = new Vector3(0, 0, 0);
		}
		
		// Moving
		if (Input.GetKey(KeyCode.UpArrow)) {
			//transform.position += (transform.forward * moveSpeed * Time.deltaTime);
			//rigidbody.velocity = (transform.forward * moveSpeed * Time.deltaTime);
			rigidbody.AddForce(transform.forward * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.DownArrow)) {
			rigidbody.AddForce(-transform.forward * moveSpeed * Time.deltaTime);
			//rigidbody.velocity = (-transform.forward * moveSpeed * Time.deltaTime);
		}
		
		// Jumping
		if (Input.GetKeyDown(KeyCode.Space)) {
			rigidbody.AddForce(transform.up * jumpHeight * Time.deltaTime);
		}
		
	}
}
