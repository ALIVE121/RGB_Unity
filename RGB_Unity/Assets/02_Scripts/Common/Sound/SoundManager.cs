using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    public Sprite[] ChangeImg;
    public Image CanvasIamge;

    private bool BgmSoundSw = false;
    public void SoundPlay()
    {
        if(!BgmSoundSw)
        {
            CanvasIamge.GetComponent<Image>().sprite = ChangeImg[1];
            this.GetComponent<AudioSource>().volume = 0;
            BgmSoundSw = true;
        }
        else
        {
            CanvasIamge.GetComponent<Image>().sprite = ChangeImg[0];
            this.GetComponent<AudioSource>().volume = 1;
            BgmSoundSw = false;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
