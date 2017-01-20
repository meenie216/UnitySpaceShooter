using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	void Start()
	{
		var rb = GetComponent<Rigidbody>();

		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}

}
