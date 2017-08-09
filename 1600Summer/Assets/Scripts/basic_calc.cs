using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class basic_calc : MonoBehaviour {

	public InputField in1, in2, in3, in4, in5, in6, in7, in8;
	public Text result, result2, result3, result4;

	public void ModClick(){
		int num = int.Parse(in1.text) % int.Parse(in2.text);
		result.text = num.ToString();

	}

	public void AddClick(){
		int num = int.Parse(in1.text) + int.Parse(in2.text);
		result.text = num.ToString();

	}

	public void SubClick(){
		int num = int.Parse(in1.text) - int.Parse(in2.text);
		result.text = num.ToString();

	}

	public void DivClick(){
		int num = int.Parse(in1.text) / int.Parse(in2.text);
		result.text = num.ToString();

	}

	public void MultClick(){
		int num = int.Parse(in1.text) * int.Parse(in2.text);
		result.text = num.ToString();

	}


}
