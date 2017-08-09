using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour {
	void Start (){
		int num = AddNumbers(20,31);
		print(num);
	}

	/* 
	void Toaster (int slot1, int slot2){
		if (slot1 == 1 || slot2 == 1)
		{
			print("Bread is toasted.");
		}
		else if(slot1 == 1 && slot2 == 1)
		{
			print("Both slices of bread are toasted.");
		}
		else
		{
			print("Nothing is toasted.");
		}
		

	}
	*/

	public int AddNumbers(int number1, int number2)
	{
		int result = number1 + number2;

		return result;
	}

}
