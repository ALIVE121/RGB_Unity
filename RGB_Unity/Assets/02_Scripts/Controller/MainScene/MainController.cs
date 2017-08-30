using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainController : MonoBehaviour {
    float scount;
    float ncount;
    GameObject Fade_In;
	// Use this for initialization
  
	void Start () {
        ncount = 0.0f;
        scount = 9.5f;
        Fade_In = GameObject.FindWithTag("Fade_In");

        StartCoroutine(DestroyFadeIn());
	}
    private IEnumerator DestroyFadeIn()
    {
        yield return new WaitForSeconds(9.5f);

        Destroy(Fade_In.gameObject);
    }
  
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
            
	    }

        if (Input.touchCount > 0)
        {
            if (Fade_In == null)
            {
                Debug.Log("앙 기모띠");
                SceneManager.LoadScene("ChapterSelect");
            }
        }
        if (Input.GetMouseButtonDown(0))
        {

            if (Fade_In == null)
            {
                Debug.Log("앙 기모띠");
                SceneManager.LoadScene("ChapterSelect");
            }
        }
    }
}