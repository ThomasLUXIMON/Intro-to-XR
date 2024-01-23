using UnityEngine;
using UnityEngine.InputSystem;

public class lightSCRIPT : MonoBehaviour
{
    public lightSCRIPT light;
 
    //
    void Start() {
        light = GetComponent<lightSCRIPT>();
    if (Input.GetKeyDown("tab"))
        {
            lightSCRIPT.color = Color.red;

        }
    }
}