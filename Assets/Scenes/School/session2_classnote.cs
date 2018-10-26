using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session2_classnote : MonoBehaviour {

    //Session 2: Conditionals, Loops and Classes 

    //1.Shorthand conditions  (if)

    int number1 = 10;
    int number2 = 20;
    int number3 = 30;

    string[] tutorNames = { "Dave", "Tyson", "Jordi", "Octavian", "Panis" };
    bool someBool = false;

    //ask question about your datas.e.g -- if.
    private void Start()

    {
        Debug.Log("A tutor is" + tutorNames[0]);


        for (int i = 0; i < tutorNames.Length; i++)
        {
            Debug.Log("A tutor is" + tutorNames[i]);
        }


        if (number1 < number2) //Condition

        //Action if true.
        {
            Debug.Log("number 1 is smaller than number 2");
        }

        else //Action is false.
        {
            Debug.Log("number 2 is smaller than number 2");
        }

        //foreach loop.
        foreach (string tutorName in tutorNames)
        {
            Debug.Log(tutorName);
        }



    }

    //Asking multiquestion.

    private void a()
    {
        if (number1 < number2 && number2 < number3)
        {
            Debug.Log("Action to both question is yes");
        }
    }


    // && = both true = true ; 
    // || = one of them is true = ture;

    //Complex question by concatenation and by embedding sub questions.

  
}







//2.For and foreach loops

//3.Class extension

public class human : MonoBehaviour 
{
    //properties(variables)

    string name = "Tyson";
    int age = 32;
    float height = 175.5f;
    float energy = 100f;

    //behaviours(function)
    void Walking() { }

    void Sleeping() { }

}

public class cyborg : human
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}



//4.Interfaces:// inportant idea.





//5.Composition



