using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public Rigidbody bullet;
	public Transform SpawnPoint;
	public int shootSpeed;

	void Update ()
    {
		if (Input.GetButtonDown("Fire1"))
		{
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(bullet, SpawnPoint.position, bullet.rotation);
			clone.velocity = SpawnPoint.TransformDirection (Vector3.forward*shootSpeed);
		}
	}


	}
