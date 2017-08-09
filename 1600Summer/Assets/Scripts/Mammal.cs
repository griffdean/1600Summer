using UnityEngine;
using System.Collections;

public class Mammal : Animal {

    //Properties
    //Hair
    public bool hasHair = true;
    public Color hairColor = Color.grey;
    //Warm Blooded
    public bool warmBlooded = true;
    //HowManyLegs {1, 2, 4}
    public int legCount = 1;

    //Functions
    //Live Birth Overrides Reproduction
    //Feed Milk
    //Bite
    
    void Start()
    {
        if (!(hasHair && legCount == 1))
        {
            print("This is not a mammal.");
        }
        else
        {
            print("This is a mammal.");
        }

        if (warmBlooded || legCount < 1)
        {
            print("This is a mammal.");
        }
        else
        {
            print("This is not a mammal.");
        }

        
    }
}
