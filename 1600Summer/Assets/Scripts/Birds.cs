using UnityEngine;
using System.Collections;

public class Birds : Animal {

    //Properties
    //Feather count
    public int feathers = 100;
    //Beaks
    public float beakLength = 0.25f;
    //Wings bool for if they work
    public bool wings = true;
    //Color
    public Color featherColor = Color.red;

    //Functions
	//BuildNests
    //Fly
    //Call

    void Start ()
    {
        if (wings && feathers > 0)
        {
            print("Flying");
        }
        else
        {
            print("Bird is lame.");
        }

        if (beakLength < 0.1f || beakLength > 10)
        {
            print("This bird is too small, or too big.");
        }
    }
}
