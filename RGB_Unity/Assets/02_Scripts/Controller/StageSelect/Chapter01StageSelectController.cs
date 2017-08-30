using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Chapter01StageSelectController : MonoBehaviour {
    GameObject StageSelectFadeIn;
    GameObject Stage_01;
    GameObject Stage_02;
    GameObject Stage_03;
    GameObject Stage_04;
    GameObject Stage_05;
    GameObject Stage_06;

    void Awake()
    {
        Stage_01 = GameObject.Find("Stage_01");
        Stage_02 = GameObject.Find("Stage_02");
        Stage_03 = GameObject.Find("Stage_03");
        Stage_04 = GameObject.Find("Stage_04");
        Stage_05 = GameObject.Find("Stage_05");
        Stage_06 = GameObject.Find("Stage_06");
        StageSelectFadeIn = GameObject.Find("Fade_In");
    }
    void Start()
    {
        StartCoroutine(DestroyFadeIn());
    }
    private IEnumerator DestroyFadeIn()
    {
        yield return new WaitForSeconds(8.0f);
        Destroy(StageSelectFadeIn.gameObject);
    }
    public void OnClick(GameObject On)
    {
        if (On == Stage_01)
        {
            Debug.Log("A");
   
            //SceneManager.LoadScene("Stage_01");
        }
        else if (On == Stage_02)
        {
            Debug.Log("B");
         
            //SceneManager.LoadScene("Stage_02");
        }
        else if (On == Stage_03)
        {
            Debug.Log("C");
            
            //SceneManager.LoadScene("Stage_03");
        }
        else if (On == Stage_04)
        {
            Debug.Log("D");
            //SceneManager.LoadScene("Stage_04");
        }
        else if (On == Stage_05)
        {
            Debug.Log("E");
            //SceneManager.LoadScene("Stage_05");
        }
        else if (On == Stage_06)
        {
            Debug.Log("F");
            //SceneManager.LoadScene("Stage_06");
        }
    }
}
