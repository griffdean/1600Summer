﻿using UnityEngine;
using System.Collections;

public class wolfAI : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;

	void OnTriggerStay(Collider other){
		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision other){
		var hit = other.gameObject;
		var health = hit.GetComponent<playerHealth>();

		if (health != null)
		{
			health.TakeDamage(damage);
		}
	}
}
