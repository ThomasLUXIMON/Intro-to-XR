using UnityEngine;

public class Breakout : MonoBehaviour
{
    Vector3 Initial_position;
    Vector3 Position_A;

    public void Start()
    {
        Initial_position = transform.position;
        Position_A = new Vector3(0f, 50, 0f);
        }
    public void Update()
    {
        if (Input.GetKeyDown("Button.Two"))
        {
            if (transform.position == Position_A)
            {
                transform.position = Initial_position;
            }
            else
            {
                transform .position = Position_A;
            }
        }
           

    }
}
