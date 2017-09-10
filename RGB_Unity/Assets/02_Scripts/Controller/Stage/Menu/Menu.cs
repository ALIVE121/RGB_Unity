using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    private Touch tempTouchs;
    private Vector3 touchedPos;
    GameObject Me;
    SpriteRenderer Spirt;
    Touch touch;
    public Animator anime;

    // private float basePosition;

    void Awake()
    {
        Spirt = GetComponent<SpriteRenderer>();
        Me = GameObject.Find("Menu");



    }

    void OnMouseDown()
    {

        // Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //pos = Input.mousePosition - pos;

        //       WorldTouchPoint();
        //        Touch();
        /*
                Debug.Log("안녕");
                anime.SetBool("ani", true);
                if (anime == true)
                {
                if (tempTouchs.phase == TouchPhase.Began)
                 {
                 {
           //     WorldTouchPoint();
             //    Touch();
                 anime.SetBool("Anime", false);
                 if (anime == false)
                 {
                 anime2.SetBool("ani2", true);
                 if (anime2 == true)
                 {
                 if (Input.touchCount > 0)
                {
                if (tempTouchs.phase == TouchPhase.Began)
                {

                 WorldTouchPoint();
                 Touch();
                 anime.SetBool("MenuDown", true);


                         }
                     }
                }
               }

             }

            }


          }
          */

        if (anime.GetBool("runningAni") == true)
            return;


        // 창 오픈
        if (anime.GetBool("isOpen") == false)
        {
            anime.SetBool("runningAni", true);

            anime.SetBool("isOpen", true);

        }
        else
        {
            anime.SetBool("runningAni", true);

            anime.SetBool("isOpen", false);
        }



    }

    public void DoneAni()
    {
        anime.SetBool("runningAni", false);
    }


}