using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class End : MonoBehaviour {
    private SpriteRenderer spriteRenderer;
    public Sprite CurrenSprite;
    public Sprite Nextsprites;
    
    public int colorIndex;
    public int endpointcount;
   

    // Use this for initialization
    void Start () {
        // RaycastHit hit = Goal.gameObject.GetComponent<Laser>().currHit;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = CurrenSprite;
          
    }
    public void EndPointCount(int End)
    {
        if (endpointcount == End)
        {
            Debug.Log("over");
            //Application.LoadLevel("");

        }
        

        
    }
    public void gameEndCount(int EndCount)
    {
        Debug.Log("?");
        if (EndCount == endpointcount)
        {
            Debug.Log("Done");
        }
    }
    public void gameEnd(int laserColorIndex)
    {
        Debug.Log("Game End");

    
        if(laserColorIndex == colorIndex)
          spriteRenderer.sprite = Nextsprites;
        
    }

    public void resetSprite()
    {
        spriteRenderer.sprite = CurrenSprite;
    }
}

