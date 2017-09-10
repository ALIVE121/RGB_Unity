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
    GameObject Stage_01lock;
    GameObject Stage_02lock;
    GameObject Stage_03lock;
    GameObject Stage_04lock;
    GameObject Stage_05lock;
    GameObject Stage_06lock;
    GameObject Stage_07lock;
    //
    GameObject ChangeHardLevel_Chapter01;
    GameObject ChangeNomalLevel_Chapter01;
    GameObject Stage_01Hard;
    GameObject Stage_02Hard;
    GameObject Stage_03Hard;
    GameObject Stage_04Hard;
    GameObject Stage_05Hard;
    GameObject Stage_06Hard;
    GameObject Stage_01Hardlock;
    GameObject Stage_02Hardlock;
    GameObject Stage_03Hardlock;
    GameObject Stage_04Hardlock;
    GameObject Stage_05Hardlock;
    GameObject Stage_06Hardlcok;
    //
    GameObject Chapter02Stage01;
    GameObject Chapter02Stage02;
    GameObject Chapter02Stage03;
    GameObject Chapter02Stage04;
    GameObject Chapter02Stage05;
    GameObject Chapter02Stage06;
    GameObject Chapter02Stage01Hard;
    GameObject Chapter02Stage02Hard;
    GameObject Chapter02Stage03Hard;
    GameObject Chapter02Stage04Hard;
    GameObject Chapter02Stage05Hard;
    GameObject Chapter02Stage06Hard;
    //
    GameObject Chapter02Stage01Hardlock;
    GameObject Chapter02Stage02Hardlock;
    GameObject Chapter02Stage03Hardlock;
    GameObject Chapter02Stage04Hardlock;
    GameObject Chapter02Stage05Hardlock;
    GameObject Chapter02Stage06Hardlock;
    GameObject Chapter02Stage01lock;
    GameObject Chapter02Stage02lock;
    GameObject Chapter02Stage03lock;
    GameObject Chapter02Stage04lock;
    GameObject Chapter02Stage05lock;
    GameObject Chapter02Stage06lock;
    GameObject ChangeHardLevel_Chapter02;
    GameObject ChangeNomalLevel_Chapter02;
    //
    void Awake()
    {

        FindStage();
        FindStageLock();
        FindChangeLevel();
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

            SceneManager.LoadScene("Stage_01");
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

        else if (On == Stage_01lock)
        {
            Debug.Log("lock_A");

        
        }
        else if (On == Stage_02lock)
        {
            Debug.Log("lock_B");

         
        }
        else if (On == Stage_03lock)
        {
            Debug.Log("lock_C");

         
        }
        else if (On == Stage_04lock)
        {
            Debug.Log("lock_D");

        }
        else if (On == Stage_05lock)
        {
            Debug.Log("lock_E");

        
        }
        else if (On == Stage_06lock)
        {
            Debug.Log("lock_D");

        //
        }
        else if(On== ChangeHardLevel_Chapter01) {
            SceneManager.LoadScene("Chapter01_Hard");
        }
        else if (On == ChangeNomalLevel_Chapter02)
        {
            SceneManager.LoadScene("Chapter02");
        }
        else if (On == ChangeHardLevel_Chapter02)
        {
            SceneManager.LoadScene("Chapter02_Hard");
        }
        else if (On == ChangeNomalLevel_Chapter01)
        {
            SceneManager.LoadScene("Chapter01");
        }
        //
        else if (On == Stage_01Hard)
        {
            Debug.Log("B");
           //SceneManager.LoadScene("Stage_01Hard");
        }
        else if (On == Stage_02Hard)
        {
            Debug.Log("B");
         //SceneManager.LoadScene("Stage_02Hard");
        }
        else if (On == Stage_03Hard)
        {
            Debug.Log("B");
          //SceneManager.LoadScene("Stage_03Hard");
        }
        else if (On == Stage_04Hard)
        {
            Debug.Log("B");
        //SceneManager.LoadScene("Stage_04Hard");
        }
        else if (On == Stage_05Hard)
        {
            Debug.Log("B");
         //SceneManager.LoadScene("Stage_05Hard");
        }
        else if (On == Stage_06Hard)
        {
            Debug.Log("B");
          //SceneManager.LoadScene("Stage_62Hard");
        }
        else if (On == Stage_01Hardlock)
        {
            Debug.Log("lock_A");
        }
        else if (On == Stage_02Hardlock)
        {
            Debug.Log("lock_B");
        }
        else if (On == Stage_03Hardlock)
        {
            Debug.Log("lock_C");
        }
        else if (On == Stage_04Hardlock)
        {
            Debug.Log("lock_D");
        }
        else if (On == Stage_05Hardlock)
        {
            Debug.Log("lock_E");
         }
        else if (On == Stage_01Hardlock)
        {
            Debug.Log("lock_D");
         }
        //
        else if (On == Stage_01Hard)
        {
            Debug.Log("B");
            //SceneManager.LoadScene("Stage_01Hard");
        }
        else if(On== Chapter02Stage01)
        {
           // SceneManager.LoadScene("Chapter02Stage02");
        }
        else if (On == Chapter02Stage02)
        {
           // SceneManager.LoadScene("Chapter02Stage03");
        }
        else if (On == Chapter02Stage03)
        {
           // SceneManager.LoadScene("Chapter02Stage03");
        }
        else if (On == Chapter02Stage04)
        {
            //SceneManager.LoadScene("Chapter02Stage04");
        }
        else if (On == Chapter02Stage05)
        {
           // SceneManager.LoadScene("Chapter02Stage05");
        }
        else if (On == Chapter02Stage06)
        {
           // SceneManager.LoadScene("Chapter02Stage06");
        }
        else if (On == Chapter02Stage01Hard)
        {
            //SceneManager.LoadScene("Chapter02Stage01Hard");
        }
        else if (On == Chapter02Stage02Hard)
        {
           // SceneManager.LoadScene("Chapter02Stage02Hard");
        }
        else if (On == Chapter02Stage03Hard)
        {
           // SceneManager.LoadScene("Chapter02Stage03Hard");
        }
        else if (On == Chapter02Stage04Hard)
        {
            //SceneManager.LoadScene("Chapter02Stage04Hard");
        }
        else if (On == Chapter02Stage05Hard)
        {
           // SceneManager.LoadScene("Chapter02Stage05Hard");
        }
        else if (On == Chapter02Stage06Hard)
        {
            //SceneManager.LoadScene("Chapter02Stage06Hard");
        }
    }
    public void FindStageLock()
    {
        Stage_01lock = GameObject.Find("Stage_01lock");
        Stage_02lock = GameObject.Find("Stage_01lock");
        Stage_03lock = GameObject.Find("Stage_01lock");
        Stage_04lock = GameObject.Find("Stage_01lock");
        Stage_05lock = GameObject.Find("Stage_01lock");
        Stage_06lock = GameObject.Find("Stage_01lock");
        Stage_01Hardlock = GameObject.Find("Stage_01Hardlock");
        Stage_02Hardlock = GameObject.Find("Stage_01Hardlock");
        Stage_03Hardlock = GameObject.Find("Stage_01Hardlock");
        Stage_04Hardlock = GameObject.Find("Stage_01Hardlock");
        Stage_05Hardlock = GameObject.Find("Stage_01Hardlock");
        Stage_06Hardlcok = GameObject.Find("Stage_01Hardlock");
        Chapter02Stage01lock = GameObject.Find("Chapter02Stage01lock");
        Chapter02Stage02lock = GameObject.Find("Chapter02Stage02lock");
        Chapter02Stage03lock = GameObject.Find("Chapter02Stage03lock");
        Chapter02Stage04lock = GameObject.Find(" Chapter02Stage04lock");
        Chapter02Stage05lock = GameObject.Find("Chapter02Stage05lock");
        Chapter02Stage06lock = GameObject.Find("Chapter02Stage06lock");
        Chapter02Stage01Hardlock = GameObject.Find("Chapter02Stage01Hardlock");
        Chapter02Stage02Hardlock = GameObject.Find("Chapter02Stage02Hardlock");
        Chapter02Stage03Hardlock = GameObject.Find("Chapter02Stage03Hardlock");
        Chapter02Stage04Hardlock = GameObject.Find("Chapter02Stage04Hardlock");
        Chapter02Stage05Hardlock = GameObject.Find("Chapter02Stage05Hardlock");
        Chapter02Stage06Hardlock = GameObject.Find("Chapter02Stage06Hardlock");
    }
    public void FindStage()
    {
        Stage_01 = GameObject.Find("Stage_01");
        Stage_02 = GameObject.Find("Stage_02");
        Stage_03 = GameObject.Find("Stage_03");
        Stage_04 = GameObject.Find("Stage_04");
        Stage_05 = GameObject.Find("Stage_05");
        Stage_06 = GameObject.Find("Stage_06");
        Stage_01Hard = GameObject.Find("Stage_01Hard");
        Stage_02Hard = GameObject.Find("Stage_02Hard");
        Stage_03Hard = GameObject.Find("Stage_03Hard");
        Stage_04Hard = GameObject.Find("Stage_04Hard");
        Stage_05Hard = GameObject.Find("Stage_05Hard");
        Stage_06Hard = GameObject.Find("Stage_06Hard");
        Chapter02Stage01 = GameObject.Find("Chapter02Stage01");
        Chapter02Stage02 = GameObject.Find("Chapter02Stage02");
        Chapter02Stage03 = GameObject.Find("Chapter02Stage03");
        Chapter02Stage04 = GameObject.Find("Chapter02Stage04");
        Chapter02Stage05 = GameObject.Find("Chapter02Stage05");
        Chapter02Stage06 = GameObject.Find("Chapter02Stage06");
        Chapter02Stage01Hard = GameObject.Find("Chapter02Stage01Hard");
        Chapter02Stage02Hard = GameObject.Find("Chapter02Stage02Hard");
        Chapter02Stage03Hard = GameObject.Find("Chapter02Stage03Hard");
        Chapter02Stage04Hard = GameObject.Find("Chapter02Stage04Hard");
        Chapter02Stage05Hard = GameObject.Find("Chapter02Stage05Hard");
        Chapter02Stage06Hard = GameObject.Find("Chapter02Stage06Hard");
    }
    public void FindChangeLevel()
    {
        ChangeHardLevel_Chapter01 = GameObject.Find("ChangeHardLevel_Chapter01");
        ChangeNomalLevel_Chapter01 = GameObject.Find("ChangeNomalLevel_Chapter01");
        ChangeHardLevel_Chapter02 = GameObject.Find("ChangeHardLevel_Chapter02");
        ChangeNomalLevel_Chapter02 = GameObject.Find("ChangeNomalLevel_Chapter02");
        StageSelectFadeIn = GameObject.Find("Fade_In");
    }
}

