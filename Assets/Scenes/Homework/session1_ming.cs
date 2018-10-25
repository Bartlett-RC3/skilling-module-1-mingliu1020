using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class session1_ming : MonoBehaviour
{
    //1. Int Variable.
    public int myAge = 24;

    //2.float Variable.
    public float myheight = 167.5f;

    //3.string Varable.
    public string myUniversity = "University College London";

    //4.a function that prints the declared variables. 
    public class Me
    {
        string name = "Ming Liu";
        int age = 24;
        public void introduction()
        {
            Console.WriteLine("My name is" + name + "and I am" + age);
        }
    }

    //5.array.

    public string[] pets = { "brulee", "bubble", "ketty" };

    //6.list.

    static void Main(string[] args) {

        List<string> pets = new List<string>();

        pets.Add("brulee");
        pets.Add("bubble");
        pets.Add("ketty");

      }

    //7.Dictionary

    static void computer (string[] args)
    {
        Dictionary<string, string> software = new Dictionary<string, string>();

        software.Add("AutoCad", ".dwg");
        software.Add("SketchUp", ".skp");
        software.Add("word", ".docx");
        software.Add("powerpoint", "pptx");

        string a = software["AutoCad"];
        Console.WriteLine("the document end is" + a);
    }



}

















