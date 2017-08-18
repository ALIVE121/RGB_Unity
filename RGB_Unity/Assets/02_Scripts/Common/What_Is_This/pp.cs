using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pp : MonoBehaviour {

    public GameObject cube;
 
    void Start()
    {

    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cube.SetActive(false);
        }
        if (Input.GetMouseButtonDown(1))
        {
          
            cube.SetActive(true);
        }
    }

}
