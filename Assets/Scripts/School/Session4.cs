using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour {

    // Variables
    public GameObject columnPrefab;
    IEnumerator createColumnCoroutine; //

	// Use this for initialization
	void Start () {
        createColumnCoroutine = DropColumns();  
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(createColumnCoroutine); //StartCoroutine 
        Debug.Log(Time.time);
        if(Time.time > 5)
        {
            StopCoroutine(createColumnCoroutine);
            StopAllCoroutines();
        }
    }

    // Coroutines = IEnumerator.interface. if you need to excute a code for a while, or excude it couple of times.
    IEnumerator DropColumns()
    {
        while (true)   //while sth is true and it is always true. (condition) condition could be whatever you want it to start.
        {
            Vector3 columnPosition = new Vector3(Random.Range(-5f, 3f), Random.Range(8f, 15f), Random.Range(-7f, 0f)); //while this is ture, make the position.
            Quaternion columnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1); //while this is ture, rotate it this way.
            GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation); //Instantiate (object, 
            yield return new WaitForSeconds(5); //yield: when it ends. 
        }
    }
}
