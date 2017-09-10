using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour {
    GameObject GlassBox;
    GameObject FadeInStage;
    GameObject retry;
	void Awake()
    {
        GlassBox = GameObject.Find("GlassBox");
        FadeInStage = GameObject.Find("FadeInStage");
        retry = GameObject.Find("retry");

    }
	void Start () {

        StartCoroutine(DestroyStageFade());

    }
    private IEnumerator DestroyStageFade()
    {
        yield return new WaitForSeconds(9.5f);
        Destroy(FadeInStage.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   private void OnClick()
    {
        

    }
}
