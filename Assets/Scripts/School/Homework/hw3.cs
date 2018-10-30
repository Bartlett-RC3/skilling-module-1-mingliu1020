using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RC3
{
    public class hw3 : MonoBehaviour
    {
        //object-prefab cube
        public GameObject Prefab;
        public GameObject light;

        //array factors
        public int countX = 10;
        public int countY = 10;

        //array cubes  - for loop
        void Start()
        {
            for (int a = 0; a < countX; a++)
            {
                for (int b = 0; b < countY; b++)
                {
                    GameObject copy = Instantiate(Prefab, transform);
                }
            }
        }//start

        void Update()
        {
            //Translation.Move
            foreach (Transform copy in transform)
            {
                copy.Translate(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
            }

            //change color when mouse pressed.(0 left, 1 right, 2 middle)
            if (Input.GetMouseButton(0))
            {
                light.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
            }
          
        }//update
    }//class
}//namespace
