using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Laser : MonoBehaviour {


    LineRenderer lineRenderer;
    Ray ray;
    public RaycastHit currHit;
    private RaycastHit prevHit;
    GameObject Goal;
    public Vector3 initDirectVector;
    
    Vector3 directVector;
    Vector3 reflectVector;
    
    List<Vector3> linePosition;
    public int EndCount;
    bool isGameEnd;
    int End;
    public int laserColorIndex;
    End currEnd;

    void Awake()
    {

        linePosition = new List<Vector3>();
        lineRenderer = GetComponent<LineRenderer>();
       // spriteRenderer = Goal.GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = CurrenSprite;
        initDirectVector = transform.right;
        directVector = initDirectVector;

     //   isGameEnd = false;
    }

    // Use this for initialization
    void Start()
    {
        if (laserColorIndex == 1)
        {
            lineRenderer.material.color = Color.red;
        }
        else if (laserColorIndex == 2)
        {
            lineRenderer.material.color = Color.green;
        }
        else if (laserColorIndex == 3)
        {
            lineRenderer.material.color = Color.blue;
        }
        // Goal = GameObject.FindGameObjectWithTag("Goal");//
      
    }
    // Update is called once per frame
    void Update()
    {
       // if (isGameEnd)
          //  return;

        linePosition.Clear();

        initLineRenderer();

        ray = new Ray(transform.position, initDirectVector);
        

        Vector3 initPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        linePosition.Add(initPos);

        while (true)
        {
            currHit = shootLight(ray.origin, ray.direction);
            string tag = getCollidedObjectTag(currHit);
            
            //   Debug.DrawRay(ray.origin, ray.direction * currHit.distance, Color.magenta);
            Vector3 pos = new Vector3(currHit.point.x, currHit.point.y, currHit.point.z);
            linePosition.Add(pos);

            if (tag == "Mirror")
            {
                //거울에 충돌

                directVector = Vector3.Reflect(currHit.point - ray.origin, currHit.normal);
                //    lineRenderer.SetPosition(i, directVector);//반사
                ray = new Ray(currHit.point, directVector);

                if (currEnd != null)
                {
                    currEnd.resetSprite();
                    currEnd = null;
                }
            }
            else if (tag == "Wall")
            {
                if (currEnd != null)
                {
                    currEnd.resetSprite();
                    currEnd = null;
                }
                //벽에 충돌
                // lineRenderer.SetPosition(i,new Vector3(currHit.distance,0,0));//맞은 곳까지만 출력
                break;
            }
            else if (tag == "Goal")
            {
                currEnd = currHit.transform.gameObject.GetComponent<End>();
                currEnd.gameEnd(laserColorIndex);
                currEnd.gameEndCount(EndCount);
                break;
                //게임 종료. 클리어 연출
                //  spriteRenderer.sprite = Nextsprites;

               

             
              
            }
        }

        lineRendering();
    }

    RaycastHit shootLight(Vector3 transform, Vector3 direction)
    {
        RaycastHit hit;
        Physics.Raycast(transform, direction, out hit, Mathf.Infinity);
        return hit;
    }

    string getCollidedObjectTag(RaycastHit hit)
    {
        string tag = hit.transform.tag;

        return tag;
    }

    void initLineRenderer()
    {
        lineRenderer.SetWidth(0.1f, 0.1f);
    }


    void lineRendering()
    {
        lineRenderer.positionCount = linePosition.Count;

        for (int index = 0; index < linePosition.Count; index++)
        {
            lineRenderer.SetPosition(index, linePosition[index]);
        }
    }
}