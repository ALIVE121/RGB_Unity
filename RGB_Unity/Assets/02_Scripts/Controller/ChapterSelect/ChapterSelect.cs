using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChapterSelect : MonoBehaviour
{
    GameObject Chapter_Fade_In;
    GameObject Chapter_01;
    GameObject Chapter_02;
    GameObject Chapter_03;
    GameObject Chapter_04;
    GameObject Chapter_05;
    GameObject Chapter_02lock;
    int t = 0;


    void Awake() //만든 전역변수에 각자 맞는 테그를 가져다가 찾습니다.
    {
        
        Chapter_01 = GameObject.Find("Chapter_01");
        Chapter_02 = GameObject.Find("Chapter_02");
        Chapter_03 = GameObject.Find("Chapter_03");
        Chapter_04 = GameObject.Find("Chapter_04");
        Chapter_05 = GameObject.Find("Chapter_05");
      //  Chapter_02lock = GameObject.FindWithTag("Chapter_02lock");
        Chapter_Fade_In = GameObject.FindWithTag("Fade_In2");

        
    }

    void Start()
    {
       
      
        StartCoroutine(DestroyFadeIn());
    }

    private IEnumerator DestroyFadeIn()
    { 
        yield return new WaitForSeconds(9.0f);
        Destroy(Chapter_Fade_In.gameObject);
        t = t + 1;
        Debug.Log("앙");

    }

    void Update()
    {
        /*
        ncount += Time.deltaTime;

        if (ncount > scount)
        {
            if(Chapter_Fade_In)
            {
                Debug.Log("앙");
                Destroy(Chapter_Fade_In.gameObject);
                Chapter_Fade_In = null;
            }
        }
        */
    }

    public void Onclick(GameObject go) {
        if (t == 1)
        {
            /*Onclick으로 if문 사용해서 눌린 버튼에 따라 다르게 씬 이동을 하도록 만들었습니다.*/
        
            if (go == Chapter_01)
            {
                
                
                    SceneManager.LoadScene("Chapter01");
                    Debug.Log("A");
               
            }
            else if (go == Chapter_02)
            {
                //SceneManager.LoadScene("Chapter02");
                Debug.Log("B");
            }

            else if (go == Chapter_03)
            {
                //SceneManager.LoadScene("Chapter03");
                Debug.Log("C");
            }
            else if (go == Chapter_04)
            {
                //SceneManager.LoadScene("Chapter04");
                Debug.Log("D");
            }
            else if (go == Chapter_05)
            {
                //SceneManager.LoadScene("Chapter05");
                Debug.Log("E");
            }
            else if (go == Chapter_02lock)
            {
                Debug.Log("als");
            }
        }
     }
}