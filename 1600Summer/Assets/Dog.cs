using UnityEngine;
using System.Collections;

public class Dog : MammalsWithLegs {

    //Properties
    //HowManyLegs Override {4}
    public int numLegs = 4;
    //Paws
    public bool paws = true;
    //Tail
    public bool tail = true;

    //Functions
    //Bark
    //Attack

    void Start ()
    {
        if (numLegs < 4 || numLegs > 4)
        {
            print("This is not a dog.");
        }

        if (paws && numLegs == 4)
        {
            print("This is a dog.");
        }

        if (tail && paws)
        {
            print("This is a dog.");
        }
    }
}
