using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light light;
    //
    void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            light.color = Color.blue;
        }
    }
}