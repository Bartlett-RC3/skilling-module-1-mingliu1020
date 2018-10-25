using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1MingLiu : MonoBehaviour {




    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();
    void Start () {
        movingAnimals.Add("flying", "eagle");

        if (movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("a flying animal is:" + movingAnimals.Values);
        }



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
