using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public Transform spawnPoint;
	public int points;

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.name == "Player"){
			Destroy(gameObject);
			ScoreManager.AddPoints(points);
			//transform.position = spawnPoint.positon;
			//transform.rotation = spawnPoint.rotation;
		}
	}
}
