using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChapterSelect : MonoBehaviour
{
    //처음에 게임오브젝트 형식의 전역변수를 만듭니다.
    float scount;
    float ncount;
    GameObject Chapter_Fade_In;
    GameObject Chapter_01;
    GameObject Chapter_02;
    GameObject Chapter_03;
    GameObject Chapter_04;
    GameObject Chapter_05;
   void Awake() //만든 전역변수에 각자 맞는 테그를 가져다가 찾습니다.
    {
        Chapter_01 = GameObject.FindWithTag("Chapter_01");
        Chapter_02 = GameObject.FindWithTag("Chapter_02");
        Chapter_03 = GameObject.FindWithTag("Chapter_03");
        Chapter_04 = GameObject.FindWithTag("Chapter_04");
        Chapter_05 = GameObject.FindWithTag("Chapter_05");
        Chapter_Fade_In = GameObject.FindWithTag("Fade_In2");    }
    void start()
    {
        Chapter_Fade_In = GameObject.FindWithTag("Fade_In2");
        ncount = 0.0f;
        scount = 9.0f;
    }

    void Update()
    {
        if (ncount > scount)
        {
            Debug.Log("앙");
            Destroy(Chapter_Fade_In.gameObject);
        }
    }

    public void Onclick() {

        /*Onclick으로 if문 사용해서 눌린 버튼에 따라 다르게 씬 이동을 하도록 만들었습니다.*/

    



        if (Chapter_01)
        {
            SceneManager.LoadScene("StageSelect_01");
            Debug.Log("A");

        }
           
            if (Chapter_02)
            {
                SceneManager.LoadScene("StageSelect_02");
                Debug.Log("B");
            }

            if (Chapter_03)
            {
                SceneManager.LoadScene("StageSelect_03");
                Debug.Log("C");
            }
            if (Chapter_04)
            {
                SceneManager.LoadScene("StageSelect_04");
                Debug.Log("D");
            }
            if (Chapter_05)
            {
                SceneManager.LoadScene("StageSelect_05");
                Debug.Log("E");
            }
        }
}