using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {


    public Animator FadeInani;
    public Animation anime;
    GameObject Fade_In;
    // Use this for initialization

    void Start()
    {

        anime = GetComponent<Animation>();
        Fade_In = GameObject.FindWithTag("Fade_In");

        StartCoroutine(DestroyFadeIn());
    }
    private IEnumerator DestroyFadeIn()
    {
        yield return new WaitForSeconds(60.0f);

        Destroy(Fade_In.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (!anime.IsPlaying("fadein")) {
            if (Input.touchCount > 0)
            {
                if (Fade_In == null)
                {
                    FadeInani.SetBool("Fade", true);
                    if (FadeInani.GetBool("Fade") == true)
                    {
                        if (FadeInani.GetBool("Fade") == false) {
                            Debug.Log("앙 기모띠");

                            SceneManager.LoadScene("Stage_02");
                        }

                    }
                }
            }
            if (Input.GetMouseButtonDown(0))
            {

                FadeInani.SetBool("Fade", true);
                if (FadeInani.GetBool("Fade") == true)
                {
                    if (Fade_In == null)
                    {
                        if (FadeInani.GetBool("Fade") == false) {
                            Debug.Log("앙 기모띠");

                            SceneManager.LoadScene("Stage_02");
                        }
                    }
                }
            }
        }
    }
}
