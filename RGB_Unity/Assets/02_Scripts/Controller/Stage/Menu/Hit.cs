using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    private Touch tempTouchs;
    private Vector3 touchedPos;
    Touch touch;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void OnMouseClick () {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Touch();
        Debug.Log("Hint");
    }
    private void Touch()
    {

        if (Input.touchCount > 0)
        {

            if (tempTouchs.phase == TouchPhase.Began)
            {

                touchedPos = Camera.main.ScreenToWorldPoint(tempTouchs.position);

            }
        }
    }
   
}
