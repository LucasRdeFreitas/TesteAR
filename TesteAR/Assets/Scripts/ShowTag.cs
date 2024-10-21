using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTag : MonoBehaviour
{
    private float distance;
    private Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GameObject.Find("ARCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        distance=Vector3.Distance(cam.transform.position, transform.position);
        if (distance < 400)
        {
            transform.LookAt(cam.transform);
            transform.localScale = new Vector3(-40.0f, 40.0f, 40.0f);
        }
        else
        {
            transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
