using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class lightSCRIPT : MonoBehaviour
{
    public InputActionReference action;
    public Light light;
    //
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        light = GetComponent<Light>();
    }
    void Update()
    {

        // if (Input.GetKeyDown("Button.One"))
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