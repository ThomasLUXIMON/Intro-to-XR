using UnityEngine;
using UnityEngine.UIElements;

public class lightSCRIPT : MonoBehaviour
{
    public Light light;
    //
    void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {

        if (Input.GetKeyDown("Button.One"))
        {
            {
                
                if (Color.blue == light.color)
                {
                    light.color = Color.red;
                }
                else
                {
                    light.color = Color.blue;
                }
            }
        }
    }
}