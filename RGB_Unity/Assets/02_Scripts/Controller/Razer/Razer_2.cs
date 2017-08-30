using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Razer_2 : MonoBehaviour {

    LineRenderer lineRenderer;
    public int ReflectCount=1;
    Ray ray;
    RaycastHit currHit;
    RaycastHit prevHit;
    int i;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();

    }

    // Use this for initialization
    void Start()
    {
       
        lineRenderer.SetWidth(0.1f,0.1f);

    }

    // Update is called once per frame
    void Update()
    {
  
        
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            lineRenderer.SetPosition(0, transform.position);
             lineRenderer.SetPosition(1, currHit.point);
            ray = new Ray(transform.position, transform.right);




            if (currHit.collider != null)
            {
                Debug.DrawRay(ray.origin, ray.direction * currHit.distance, Color.magenta);

                Vector3 reflectVector = Vector3.Reflect(currHit.point - this.transform.position, currHit.normal);//노멀벡터와 입사각 백터로 반사백터 구함 
            lineRenderer.SetPosition(2,transform.position+reflectVector);
            prevHit = currHit;
               



                if (currHit.collider != null)
                {
                    Debug.DrawRay(prevHit.point, (currHit.point - prevHit.point).normalized * currHit.distance, Color.blue);
                    reflectVector = Vector3.Reflect(reflectVector, currHit.normal);
                    Debug.DrawRay(currHit.point, reflectVector * 100, Color.green);
                }
                else
                {
                    Debug.DrawRay(prevHit.point, reflectVector * 100, Color.blue);


                }

            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);

            }
        
    }
    
}
