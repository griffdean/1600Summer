using UnityEngine;
using System.Collections;

public class wolfHealth : MonoBehaviour {

	public int currentHealth;
	public int points;
	//public Transform spawnPoint;
	public int maxHealth = 3;

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if (currentHealth <= 0)
		{
			//Keep score at zero
			currentHealth = 0;
			print("Wolf is Dead!");
			//Add points to score for killing wolf
			ScoreManager.AddPoints(points);
			//Move wolf to spawn point for wolf
			Destroy(gameObject);
			//Reset Wolf Health
			currentHealth = maxHealth;
		}
	}
}
