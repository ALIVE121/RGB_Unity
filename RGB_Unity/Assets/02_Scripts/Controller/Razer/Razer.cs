using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Razer : MonoBehaviour
{

    LineRenderer lineRenderer;

    Ray2D ray;
    RaycastHit2D currHit;
    RaycastHit2D prevHit;
    private static int ReflectCount;
    public Transform orignalObject;
    public Transform reflectedObject;
    GameObject EndStage;
    private GameObject Obj;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //EndStage = GameObject.Find("EndGameObject"); 끝나는 게임 오브젝트 찾음
    }

    // Use this for initialization
    void Start()
    {
       
        lineRenderer.SetWidth(0.1f, 0.1f);
        lineRenderer.SetPosition(1, transform.position + new Vector3(50, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

        ray = new Ray2D(transform.position, transform.right);

        currHit = Physics2D.Raycast(ray.origin, ray.direction);

        if (currHit != null && currHit.collider != null)
        {
            for (int i = 0; i <= ReflectCount; i++)
            {
                Debug.DrawRay(ray.origin, ray.direction * currHit.distance, Color.magenta);
                reflectedObject.position = Vector3.Reflect(orignalObject.position, Vector3.right);
                Vector2 pos = new Vector2(transform.position.x, transform.position.y);
                Vector2 reflectVector = Vector2.Reflect(currHit.point - pos, currHit.normal);//노멀벡터와 입사각 백터로 반사백터 구함 
                pos = reflectVector;
                prevHit = currHit;
                lineRenderer.SetPosition(i,transform.position);
                currHit = Physics2D.Raycast(currHit.point + currHit.normal * 0.01f, reflectVector, Mathf.Infinity);
                if (currHit != null && currHit.collider != null)
                {
                    Debug.DrawRay(prevHit.point, (currHit.point - prevHit.point).normalized * currHit.distance, Color.blue);
                    reflectVector = Vector2.Reflect(reflectVector, currHit.normal);
                    Debug.DrawRay(currHit.point, reflectVector * 100, Color.green);
                }
                else
                {
                    Debug.DrawRay(prevHit.point, reflectVector * 100, Color.blue);
                }
            }

        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);

            // if (currHit.collider.tag == "EndGameObject")
            {
                //lineRenderer.SetPosition(currHit.point, transform.position+new Vector3(0,0,currHit.distance));
                //라인렌더러 위치값 가져오기
                // Instantiate(Obj, new Vector3(0, 0, 0), Quaternion.identity;
                //트루 체크방법
                //SceneManager.LoadScene("Stage2");
                //}
            }

        }
    }
}

