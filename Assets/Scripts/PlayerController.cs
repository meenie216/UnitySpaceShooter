using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public float tilt;
	public Boundary boundary;
	public float fireRate;

	public GameObject shot;
	public Transform shotSpawn;

	private float nextFire;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		var rb = GetComponent<Rigidbody>();

		rb.velocity = new Vector3(moveHorizontal,0.0f,moveVertical) * speed;

		rb.position = new Vector3
		(
			Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
		);

		rb.rotation = Quaternion.Euler(0.0f,0.0f, rb.velocity.x * -tilt);
	}

	void Update()
	{
		if (Input.GetButton("Fire3") && Time.time > nextFire)
		{
			GetComponent<AudioSource>().Play();
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;



}
