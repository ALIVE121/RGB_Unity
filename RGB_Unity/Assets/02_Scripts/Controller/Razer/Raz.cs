using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raz : MonoBehaviour {

    public LineRenderer line;

    private void Update()
    {
        line.enabled = true;
        Laser();
    }
    void Laser()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit))
        {
            if (hit.collider)
            {
                line.enabled = true;
                line.SetPosition(1, new Vector3(0, hit.distance, 0));
                line.SetPosition(0, transform.position);

                line.SetPosition(1, hit.transform.position);
                if (hit.collider.tag == "gralbege")
                {
                    Vector3 pos = Vector3.Reflect(hit.point - this.transform.position, hit.normal);//노멀백터와 입사각백터로 반사백터구함
                    line.SetPosition(2, pos);//구한 반사백터 라인랜더러의 인덱스2에 대입
                }
                else {
                    line.SetPosition(1, new Vector3(0, 5000, 0));

                }
            }
        }
    }
}

