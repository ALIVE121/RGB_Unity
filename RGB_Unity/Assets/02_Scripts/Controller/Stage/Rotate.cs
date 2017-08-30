using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	private float baseAngle = 0.0f;
	private Touch tempTouchs;
	private Vector3 touchedPos;
	GameObject Rot;
    SpriteRenderer Spirt;
    Touch touch;
	// Use this for initialization
    void Awake()
    {
        Spirt = GetComponent<SpriteRenderer>();
        Rot = GameObject.Find("RotateGlass");
    }
	void OnMouseDown() {
		
		Vector3 pos = Camera.main.WorldToScreenPoint (transform.position);
		pos = Input.mousePosition - pos;
		Rotateircle ();
		baseAngle = Mathf.Atan2 (pos.y, pos.x) * Mathf.Rad2Deg;
		baseAngle -= Mathf.Atan2 (transform.right.y, transform.right.x) * Mathf.Rad2Deg;
	
	}
	

	void OnMouseDrag () {
		Vector3 pos = Camera.main.WorldToScreenPoint (transform.position);
		pos = Input.mousePosition - pos;
		Rotateircle ();
		float ang = Mathf.Atan2 (pos.y, pos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (ang, Vector3.forward);
        if (Input.touchCount > 0)
        {
            
        }
    }
	private void Rotateircle(){
		
		if(Input.touchCount>0){
			if(tempTouchs.phase==TouchPhase.Began){
				touchedPos = Camera.main.ScreenToWorldPoint (tempTouchs.position);
               
}
		}
	}
}

