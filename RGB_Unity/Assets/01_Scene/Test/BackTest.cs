using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackTest : MonoBehaviour {
    public UnityEngine.UI.Image fade;
    float Fades = 0.0f;
    float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
   public void ChangeToSeccne()
    {
      //  FadeIn();
        Application.LoadLevel("Test");
    }
  //  private IEnumerator FadeIn()
    //{
     //   yield return new WaitForSeconds(5.0f);
        //time += Time.deltaTime;
   // }
}
