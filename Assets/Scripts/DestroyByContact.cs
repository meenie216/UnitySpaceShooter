﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Boundary")
			return;

		Destroy(other.gameObject);
		Destroy(gameObject);

		Instantiate(explosion, transform.position, transform.rotation);
		if(other.tag=="Player")
			Instantiate(playerExplosion, transform.position, transform.rotation);
	}
}
