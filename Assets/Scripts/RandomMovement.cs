using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {
	
	public float speed;

	void Start()
	{
		var rb = GetComponent<Rigidbody>();

		rb.velocity  = new Vector3(
			Random.Range(-3.0f,3.0f),
			0,
			- Random.Range(0.0f, 2.0f) * speed
		); 
	}

}
