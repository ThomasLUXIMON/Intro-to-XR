using UnityEngine;
using UnityEngine.InputSystem;

public class Breakout : MonoBehaviour
{
    Vector3 Initial_position;
    Vector3 Position_A;
    Vector3 Rotate_3;
    Vector3 Initial_rotate;

    
    public void Start()
    {
        
        Initial_position = transform.position;
        Position_A = new Vector3(0f, 50f, 0f);
        Rotate_3 = new Vector3(90f, 0f, 0f);
        Initial_rotate = new Vector3(-90f,0f,0f);
        }
    public void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            if (transform.position == Position_A)
            {
                transform.position = Initial_position;
                transform.Rotate(Initial_rotate);
            }
            else
            {
                transform .position = Position_A;
                transform .Rotate(Rotate_3);

            }
        }
           

    }
}
