using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

    //Properties (things they are or have)
    //BodySegments
    public string[] bodySegments = { "Head", "Abs", "Thorax" };
    public string animalName = "Jenny";

    //Health
    public int health = 100;
    //Speed
    public float speed = 0.0f;
    //Size
    public string size = "Big";
    public bool canEat = false;

    public Color baseColor;

    //Functions (things they do)
    //Breathe
    public bool canBreathe = false;
    //Reproduce
    //Eat
    void Start()
    {
        /*if (canEat)
        {
            print(this.name + " can eat.");
        }
        else
        {
            print(this.name + " can't eat.");
        }*/

        if (15 / 4 == 3)
        {
            print("3");
        }

        if (canBreathe)
        {
            print(this.name + " can breathe.");
        }

        if (animalName == "Griffon")
        {
            print("Griffon");
        }
    }
    //Move
    //Die
    //Grow


}
