using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	//public RigidBody enemy;
	public float moveSpeed;
	public Transform target;

	void Update () {
	}

	void OnTriggerStay(Collider other){
	{
		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*-moveSpeed*Time.deltaTime);	
		}
	}
}
}
