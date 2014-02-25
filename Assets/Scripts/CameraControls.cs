using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {
	
	public Transform target;
	float zoom = 10f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = target.position - (target.forward * zoom) + (target.up * zoom * 0.2f);
		transform.rotation = target.rotation;
		
		
	}
}
