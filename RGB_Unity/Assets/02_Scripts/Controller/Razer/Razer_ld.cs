using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Razer_ld : MonoBehaviour {

    private LineRenderer lineRenderer;

    private Ray ray;

    private RaycastHit hit;

    private Vector3 Direction;

    private int Points;

    //Laser Properties

    public int nReflections;
    public float LaserRange = 50.0f;
    public float LaserWidth = 0.1f;
    public Color LaserColor1;
    public Color LaserColor2;
    public Material LaserMaterial;
    void Awake()
    {

        SetUpRender();
        Debug.Log(Points);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        LaserReflections();

    }

    void LaserReflections()
    {
        Direction = transform.TransformDirection(Vector3.forward);

        ray = new Ray(transform.position, Direction);

        Points = nReflections;

        lineRenderer.SetVertexCount(Points);

        lineRenderer.SetPosition(0, this.transform.position);

        //Default LineRenderer Position (Straight out)

        for (int i = 0; i <= nReflections; i++)
        {
            if (i == 0)
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, LaserRange) == false) //If we dont hit anything
                {
                    Points = 2;
                    lineRenderer.SetPosition(1, ray.direction * LaserRange);
                }

                else if (Physics.Raycast(ray.origin, ray.direction, out hit, LaserRange) == true) //If we hit something
                {
                    Direction = Vector3.Reflect(ray.direction, hit.normal);

                    ray = new Ray(hit.point, ray.direction);

                    lineRenderer.SetPosition(i + 1, hit.point);
                }
            }
            else
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, LaserRange) == false)
                {
                    lineRenderer.SetVertexCount(Points++);

                    
                }
                else if (Physics.Raycast(ray.origin, ray.direction, out hit, LaserRange) == true)
                {

                    Direction = Vector3.Reflect(Direction, hit.normal);

                    ray = new Ray(hit.point, Direction);

                    lineRenderer.SetVertexCount(Points++);

                    lineRenderer.SetPosition(i + 1, hit.point);

                }
            }
        }

    }

    void SetUpRender()
    {
        if (GetComponent<LineRenderer>() == null)
        {
            gameObject.AddComponent<LineRenderer>();
        }

        lineRenderer = gameObject.GetComponent<LineRenderer>();

        lineRenderer.SetWidth(LaserWidth, LaserWidth);

        lineRenderer.SetColors(LaserColor1, LaserColor2);

        lineRenderer.material = LaserMaterial;
    }



}
