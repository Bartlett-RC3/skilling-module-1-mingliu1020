using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw2 : MonoBehaviour
{

    bool noRedUnderLine = true;


    void Start()
    {
        if (noRedUnderLine)
        {
            Debug.Log("There is no error in your script.");
        }

        int count = 10;
        for (int i = 0; i < count; i++)
        {
            Debug.Log(i);
        }


    }


}


public class Pet : MonoBehaviour
{
    string breed;
    string petName;
    int age;
    string color;

    public void cat()
    {
        Pet cat = new Pet();

        cat.breed = "siamese and scottish fold";
        cat.name = "brulee";
        cat.age = 4;
        cat.color = "brown";

      

    }
   
}

