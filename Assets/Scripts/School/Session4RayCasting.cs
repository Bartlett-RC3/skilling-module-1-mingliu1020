using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //RAY CASTING STEPS 
        //  第一步: create Ray, Ray direction
        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);

        // step 2: see what's infront of me , Store the object that is in front
        RaycastHit objectInFront;

        //step 3 : do sth with that object,  Ray casting
        if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))  //(origiion, direction, output info) 
        {
            string objectInFrontName = objectInFront.transform.name;
            Debug.Log("There is an object in front of me! It`s name is: " + objectInFrontName);
           
            Destroy(objectInFront.transform.gameObject);
        }

        // Move the cube up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up*0.01f);
        }

        // Move the cube down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.01f);
        }
    }
}
