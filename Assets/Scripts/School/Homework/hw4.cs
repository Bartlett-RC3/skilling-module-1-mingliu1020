using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw4 : MonoBehaviour {
    Renderer cube;


    // Use this for initialization
    void Start () {

       
        cube = GetComponent<Renderer>();
        StartCoroutine(DelayTime());

    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator DelayTime()
    {
        if (Input.GetMouseButton(0))
        {
            
            cube.material.color = Color.red;
            yield return new WaitForSeconds(5f);
        }
    }

   



}
